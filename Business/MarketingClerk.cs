using PoppelSystem.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelSystem
{
    public class MarketingClerk : Role
    {
        //data members
        private decimal salary;

        //property methods
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public MarketingClerk() : base() //defult constructor
        {
            salary = 0;
        }

        public MarketingClerk(decimal salary) : base() //parameterised constructor
        {
            RoleVal = RoleType.MarketingClerk;
            this.salary = salary;
        }

        public override decimal Payment()
        {
            return salary;
        }
    }
}
