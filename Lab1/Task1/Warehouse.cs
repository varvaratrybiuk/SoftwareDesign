using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Warehouse
    {
        protected Dictionary<Product, int> ProductDictionary = new Dictionary<Product, int>();
        public DateTime LastStockDate {  get; set; }
        public Warehouse() { }
        public abstract void AddProduct(Product product, int amount);
        public abstract void RemoveProduct(string productname);
        public abstract string GetProductInfo(string productname);
    }
}
