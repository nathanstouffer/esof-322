using System.Collections.Generic;
using System.IO;

namespace DesignPatternFinder
{
    public class PatternFinderResults : List<PatternFinderResult>
    {
        public void WriteToFile(FileInfo file)
        {
            StreamWriter writer = new StreamWriter(file.FullName, false);
            writer.WriteLine("Found " + Count + " files that possibly contain design patterns.");
            writer.WriteLine();
            foreach (PatternFinderResult result in this)
            {
                writer.WriteLine(result.File.FullName);
                writer.Write("Possible patterns: ");
                writer.WriteLine(result.PossiblePatterns.ToString());
                writer.WriteLine();
            }
            writer.Close();
        }
    }

    public class PossiblePatterns : List<PatternDefinition>
    {
        public override string ToString()
        {
            string result = string.Empty;
            foreach (PatternDefinition pattern in this)
            {
                result += pattern.Name;
                result += ", ";
            }
            return result.TrimEnd(new char[] {',', ' '});
        }
    }

    public struct PatternFinderResult
    {
        private FileInfo file;
        private PossiblePatterns possiblePatterns;

        public PatternFinderResult(FileInfo file)
        {
            this.file = file;
            possiblePatterns = new PossiblePatterns();
        }

        public FileInfo File
        {
            get { return file; }
            set { file = value; }
        }

        public PossiblePatterns PossiblePatterns
        {
            get
            {
                possiblePatterns.Sort();
                return possiblePatterns;
            }
        }

        public void AddPossiblePattern(PatternDefinition pattern)
        {
            if (!possiblePatterns.Contains(pattern))
            {
                possiblePatterns.Add(pattern);
            }
        }
    }
}