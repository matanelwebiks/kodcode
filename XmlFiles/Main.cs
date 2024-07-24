using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlFiles
{
    public class XML_First_Project
    {
        public static XmlDocument Main()
        {
            // -- XML --
            // Classes we are dealing with:
            // File, Directory, Path --> Services for Directory and File access
            // XmlDocument --> Class that represent the XML File
            // XmlNode --> Class that represents a single Node (Attributes, Inner Nodes)
            string pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..") + "\\Employees.xml");
            Console.WriteLine("Project Directory: " + pathString);
            // 1.2 Check if file exists
            if (File.Exists(pathString))
            {
                // 1.3 Create a new instance of type XmlDocument
                XmlDocument xmlDoc = new XmlDocument();
                // 1.4 Try and load the XML content into the XmlDocument object
                xmlDoc.Load(pathString);
                return xmlDoc;
            }
            return null;
        }
    }
}

