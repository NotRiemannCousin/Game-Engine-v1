using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace GE_1
{
    public class Project
    {

        public String Name { get; }
        public DateTime LastTimeOpen { get; }
        public DateTime creationTime { get; }
        public String Path { get; }
        public bool isValid { get; } = false;
        

        public Project(string path, string file)
        {
            XElement content;
            try
            {
                content = XElement.Parse(File.ReadAllText(path + "\\" + file));
            }
            catch(Exception)
            {
                return;
            }

            if (content.Element(XName.Get( "projectName")) == null ||
                content.Element(XName.Get("creationDate")) == null ||
                content.Element(XName.Get("lastTimeOpen")) == null )
                    return;

            Path = path;

            Name = content.Element(XName.Get("projectName")).Value;
            LastTimeOpen = Convert.ToDateTime(content.Element(XName.Get("lastTimeOpen")).Value);
            creationTime = Convert.ToDateTime(content.Element(XName.Get("creationDate")).Value);

            isValid = true;
        }
    }
}
