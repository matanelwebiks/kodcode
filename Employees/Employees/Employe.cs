using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{  public class Employee
    {
        //static int NextID;
        public string Id { get; set; }
        public int Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName+" "+LastName; } }
        public DateTime Birthday { get; set; }
        public int Age { get { return DateTime.Now.Year - Birthday.Year; } }

        public bool IsMale { get; set; }
        public string Status { get; set; }

        public string PhoneNumber { get; set; }
        public string City { get; set; }

        public string Street { get; set; }
        public string Number { get; set; }

        public string Address { get {return Street+" "+ Number +" "+City; }}
        public Employee() {
            //Id = ++NextID;
        }
        public Employee(int code)
        {
            Code = code;
        }
        public Employee(int code,string id ,string firstName, string lastName,DateTime birthday,
            bool isMale, string status, string phoneNumnber,string city
            ,string street, string number) {
            Code = code;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            IsMale = isMale;
            Status = status;
            PhoneNumber = phoneNumnber;
            City = city;
            Street = street;
            Number = number;

        }


    }
}
