using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelSystem.Business
{
    public class Role
    {
        //data members
        public enum RoleType
        {
            NoRole = 0,
            MarketingClerk = 1,
            WarehouseClerk = 2,
            PickingClerk = 3

            // the current system only has funtionality to work with the Marketing Clerk
            // the other functions will be implemented when required
        }
        protected RoleType roleVal;

        //property method
        public RoleType RoleVal
        {
            get { return roleVal; }
            set { roleVal = value; }
        }

        public Role() //default constructor
        {
            roleVal = Role.RoleType.MarketingClerk;
        }

        public virtual decimal Payment() //default constructor
        {
            return 0;
        }

    }
}
