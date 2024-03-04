using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ToysWarehouse : Warehouse
    {
        public ToysWarehouse()
        {
        }

        public override void AddProduct(Product product, int amount)
        {
            ProductDictionary.Add(product, amount);
           
        }

        public override string GetProductInfo(string productName)
        {
            
            foreach (var kvp in ProductDictionary)
            {
                if (kvp.Key.Name == productName)
                {
                    return kvp.Key.GetProductInfo();
                    
                }
            }
            return($"Product '{productName}' not found in Toys Warehouse.");
        }

        public override void RemoveProduct(string productName)
        {
         
            foreach (var kvp in ProductDictionary)
            {
                if (kvp.Key.Name == productName)
                {
                    ProductDictionary.Remove(kvp.Key);
                   // Console.WriteLine($"Product '{productName}' removed from Toys Warehouse.");
                    return;
                }
            }
            //Console.WriteLine($"Product '{productName}' not found in Toys Warehouse.");
        }

        
    }
}

