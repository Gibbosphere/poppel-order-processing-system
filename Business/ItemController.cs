using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelSystem.Business
{
    public class ItemController
    {

        private ItemDB itemDB;
        private Collection<Item> items;

        public Collection<Item> AllItems
        {
            get { return items; } //we set the colllection one at a time, and this is done in a separate method (within the ItemDB class)
        }

        public ItemController() //default constructor
        {
            itemDB = new ItemDB();
            items = items.AllItems;
        }

        public Collection<Item> findExpiredItems()
        {
            Collection<Item> expiredItems = new Collection<Item>(); // collection of expired items

            foreach (Item item in items)
            {
                if (item.ExpiryDate.CompareTo(DateTime.Now) < 0) // if the expiry date is earlier than the current date (i.e. if the expiry date has passed) then that item is expired
                {
                    expiredItems.Add(item); // add the expired item to the collection of expired items
                }
            }
            return expiredItems;
        }


        // Get the quantity of a product by finding all the instances of a product in the table/list of items 
        public int getProductQuantity(string productID)
        {
            int quantity = 0;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Product.ProductID == productID)
                {
                    quantity++;  // if the item has a quantity itself (beacause maybe its ordered in batches) then say: quantity += items[i].Quantity  
                }
            }
            return quantity;
        }

    }
}
