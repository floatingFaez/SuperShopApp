using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopApp
{
    class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Dictionary<int, Product> Products { get; set; }

        public Shop(string name, string address):this()
        {
            Name = name;
            Address = address;
        }

        public Shop()
        {
            Products = new Dictionary<int, Product>();
        }

        public string Add(Product aProduct)
        {
            if (HasThisId(aProduct.Id))
            {
                Products[aProduct.Id].Quentity+= aProduct.Quentity;
                return "Product is updated";
            }
            Products.Add(aProduct.Id,aProduct);
            return "Item added sucessfully";
        }

        private bool HasThisId(int id)
        {
            if (Products.ContainsKey(id))
            {
                return true;
            }
            return false;
        }


        public string GetAllProduct(Product aProduct)
        {
            string msg = "Product Id \t Quentity\n";
            foreach (Product product in Products.Values)
            {
                msg += string.Format("{0} \t\t {1}\n", product.Id, product.Quentity);
            }
            return msg;
        }
    }
}
