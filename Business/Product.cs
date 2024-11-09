using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelSystem.Business
{
    public class Product
    {

        //data members
        private string productID;
        private string productName;
        private string productDescription;
        private decimal price;

        //property methods
        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }





    }
}
