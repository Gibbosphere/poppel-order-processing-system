using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelSystem.Business
{
    public class Employee : Person
    {
        //data members
        private string empID;
        private Role role;

        //property methods
        public string EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public Role Role
        {
            get { return role; }
            set { role = value; }
        }

    }
}
