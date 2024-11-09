using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelSystem.Business
{
    public class ProductController
    {

        private ProductDB productDB;
        private Collection<Product> products;

        public Collection<Product> allProducts
        {
            get { return products; } //we set the colllection one at a time, and this is done in a separate method (within the CustomerDB class)
        }

        public ProductController() //default constructor
        {
            productDB = new ProductDB();
            products = products.AllProducts;
        }


    }
}
