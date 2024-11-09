using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelSystem.Business
{
    public class Customer : Person
    {
        //data members
        private string custID;
        private bool custCreditStatus;
        private bool custBlackList;

        //property methods
        public string CustID
        {
            get { return custID; } //ID cannot be changed
        }

        public bool CustCreditStatus
        {
            get { return custCreditStatus; }
            set { custCreditStatus = value; }
        }

        public bool CustBlackList
        {
            get { return custBlackList; }
            set { custBlackList = value; }
        }

        public void makeOrder()
        {
            return;
            // method will be fully implemented if order are made directly by customers
            // for now, this funtionality is completed by the Marketing Clerk
        }
    }
}
