using PoppelSystem.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelSystem
{
    public abstract class Person
    {
        //data members
        private string name, iD, phoneNum;

        //property methods
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ID
        {
            get { return iD; } //ID cannot be changed
        }
        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        public Person() //default constructor
        {
            name = "";
            iD = "";
            phoneNum = "";
        }

        public Person(string name, string id, string phoneNum) //parameterised constructor
        {
            this.name = name;
            this.iD = id;
            this.phoneNum = phoneNum;
        }
    }
}
