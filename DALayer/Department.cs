using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class Department
    {
        public int DepartCode { get; set; }
        public string DepartName { get; set; }

        public string Building { get; set; }

        public string ContactPerson { get; set; }
        public string Email { get; set; }
       
        public Department(string DepartName, string Building, string ContactPerson, string Email)
        {
            this.DepartCode = DepartCode;
            this.DepartName = DepartName;
            this.Building = Building;
            this.ContactPerson = ContactPerson;
            this.Email = Email;
        }
        public Department()
        {

        }
    }
}
