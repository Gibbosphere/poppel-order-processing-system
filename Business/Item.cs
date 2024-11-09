using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelSystem.Business
{
    public class Item
    {
        Product product;
        string itemID; // or batchID
        DateTime expiryDate;

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public string ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        public DateTime ExpiryDate
        {
            get { return expiryDate; }  
            set { expiryDate = value; }
        }

        public Item()
        {
            this.product = new Product();
            itemID = "";
            expiryDate = DateTime.Now;
        }

        public Item(Product product, string itemID, DateTime expiryDate)
        {
            this.product = product;
            this.itemID = itemID;
            this.expiryDate = expiryDate;
        }


    }
}
