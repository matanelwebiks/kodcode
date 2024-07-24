using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlFiles
{
    internal class Employee
    {
        private string _Path = "/Employees/Employee";
        public XmlDocument XmlDocument { get; set; }
        public Employee(XmlDocument _xmlDocument)
        {
            XmlDocument = _xmlDocument;
        }

        public void GetAllEmployees(XmlNodeList xmlNodeList = null)
        {
            if (xmlNodeList == null)
            {
                xmlNodeList = XmlDocument.SelectNodes(_Path);
            }
            foreach (XmlNode children in xmlNodeList)
            {
                if (children.Attributes != null)
                {
                    // Check all attributes
                    foreach (XmlAttribute attribute in children.Attributes)
                    {
                        Console.WriteLine(attribute.Name + ": " + attribute.Value);
                    }
                }
                if (children.ChildNodes != null) {
                    GetAllEmployees(children.ChildNodes);
                }
            }
        }

        public void GetOneEmployeeById(string id) {
            XmlNode employee = XmlDocument.SelectSingleNode(_Path + "[@id=" + id + "]");
            if (employee == null) return;
            if (employee.Attributes != null) {
                foreach (XmlAttribute attribute in employee.Attributes)
                {
                    Console.WriteLine(attribute.Name + ": " + attribute.Value);
                }
                if (employee.ChildNodes != null) { 
                    GetAllEmployees(employee.ChildNodes);
                }
            }
        
        }
    }
}
