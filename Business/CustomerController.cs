using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelSystem.Business
{
    public class CustomerController
    {
        private CustomerDB customerDB;
        private Collection<Customer> customers;

        public Collection<Customer> allCustomers
        {
            get { return customers; } //we set the colllection one at a time, and this is done in a separate method (within the CustomerDB class)
        }

        public CustomerController() //default constructor
        {
            customerDB = new CustomerDB();
            customers = customers.AllCustomers;
        }
    }
}
