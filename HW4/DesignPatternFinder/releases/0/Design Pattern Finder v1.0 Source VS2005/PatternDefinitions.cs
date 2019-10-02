using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System;

namespace DesignPatternFinder
{
    public class PatternDefinitions : List<PatternDefinition>
    {
        public void ReadFromXml(string xmlFile)
        {
            XmlTextReader reader = new XmlTextReader(xmlFile);
            PatternDefinition pattern = null;
            while (reader.Read())
            {
                XmlNodeType nodeType = reader.NodeType;

                if (nodeType == XmlNodeType.Element && reader.Name.Equals("PatternDefinition"))
                {
                    if (pattern != null)
                    {
                        Add(pattern);
                    }
                    pattern = new PatternDefinition();
                }

                else if (nodeType == XmlNodeType.Element && reader.Name.Equals("Name"))
                {
                    reader.Read();
                    pattern.Name = reader.Value;
                }

                else if (nodeType == XmlNodeType.Element && reader.Name.Equals("Tags"))
                {
                    pattern.Tags = new List<string>();
                }

                else if (nodeType == XmlNodeType.Element && reader.Name.Equals("Tag"))
                {
                    reader.Read();
                    pattern.Tags.Add(reader.Value);
                }
            }
            if (pattern != null)
            {
                Add(pattern);
            }
        }
    }

    public class PatternDefinition : IComparable<PatternDefinition>
    {
        private string name;
        private List<string> tags;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<string> Tags
        {
            get { return tags; }
            set { tags = value; }
        }

        public override bool Equals(object obj)
        {
            PatternDefinition pattern = obj as PatternDefinition;
            return pattern != null && name.Equals(pattern.name);
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public int CompareTo(PatternDefinition other)
        {
            return name.CompareTo(other.name);
        }

        public override string ToString()
        {
            return name;
        }

    }
}