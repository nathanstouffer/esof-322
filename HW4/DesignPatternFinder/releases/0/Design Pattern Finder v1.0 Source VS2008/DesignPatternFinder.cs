using System.Collections;
using System.IO;

namespace DesignPatternFinder
{
    public class DesignPatternFinder
    {
        private string extensionsString;
        private PatternFinderResults internalResults;
        private PatternDefinitions patternDefinitions;
        private PatternFinderResults results;
        private bool searchFileContent;
        private DirectoryInfo startDirectory;

        public DesignPatternFinder()
        {
            results = new PatternFinderResults();
            internalResults = new PatternFinderResults();
            patternDefinitions = new PatternDefinitions();
            patternDefinitions.ReadFromXml(Path.Combine(Directory.GetCurrentDirectory(), "PatternDefinitions.xml"));
            extensionsString = "*.java ; *.cs; *.vb ; .php";
        }

        public PatternDefinitions PatternDefinitions
        {
            get { return patternDefinitions; }
        }

        public PatternFinderResults Results
        {
            get { return results; }
        }

        public DirectoryInfo StartDirectory
        {
            get { return startDirectory; }
            set { startDirectory = value; }
        }

        public bool SearchFileContent
        {
            set { searchFileContent = value; }
        }

        public void Start()
        {
            results.Clear();
            internalResults.Clear();
            FindPatterns(startDirectory);
            results.AddRange(internalResults);
        }

        public void ResetFilter()
        {
            results.AddRange(internalResults);
        }

        public void Filter(PatternDefinition pattern)
        {
            results.Clear();
            foreach (PatternFinderResult result in internalResults)
            {
                if (result.PossiblePatterns.Contains(pattern))
                {
                    results.Add(result);
                }
            }
        }

        private void FindPatterns(DirectoryInfo directory)
        {
            FileInfo[] files = GetFilesForMultipleExtensions(directory);
            foreach (FileInfo file in files)
            {
                PatternFinderResult result;
                if (FileContainsPattern(file, out result))
                {
                    internalResults.Add(result);
                }
            }
            if (directory.GetDirectories().Length == 0)
            {
                return;
            }
            foreach (DirectoryInfo tempDirectory in directory.GetDirectories())
            {
                FindPatterns(tempDirectory);
            }
        }

        private FileInfo[] GetFilesForMultipleExtensions(DirectoryInfo directory)
        {
            ArrayList result = new ArrayList();
            string[] extensions = extensionsString.Split(new char[] {';'});

            foreach (string extension in extensions)
            {
                result.AddRange(directory.GetFiles(extension.Trim()));
            }

            return (FileInfo[]) result.ToArray(typeof (FileInfo));
        }

        private bool FileContainsPattern(FileInfo file, out PatternFinderResult result)
        {
            bool fileContainsPattern = false;
            result = new PatternFinderResult(file);

            foreach (PatternDefinition pattern in patternDefinitions)
            {
                if (file.Name.ToLower().Contains(pattern.Name.ToLower()))
                {
                    fileContainsPattern = true;
                    result.AddPossiblePattern(pattern);
                }

                if (searchFileContent)
                {
                    StreamReader reader = new StreamReader(file.FullName);
                    string fileContents = reader.ReadToEnd();
                    if (fileContents.ToLower().Contains(pattern.Name.ToLower()))
                    {
                        fileContainsPattern = true;
                        result.AddPossiblePattern(pattern);
                    }
                    reader.Close();
                }
            }

            return fileContainsPattern;
        }
    }
}