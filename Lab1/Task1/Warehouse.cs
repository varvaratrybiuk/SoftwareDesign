using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.ReportingFolder;

namespace Task1
{
    public abstract class Warehouse
    {
        public Dictionary<ProductInfo, int> ProductDictionary { get; } = new Dictionary<ProductInfo, int>();
        public delegate void ShowMessageHandler(object sender, ShowMessageEvent e);
        public event ShowMessageHandler? Message;
        public Reporting ReportingList { get; } = new Reporting();
        public Warehouse() { }
        
        public Warehouse(Dictionary<ProductInfo, int> productDictionary)
        {
            ProductDictionary = productDictionary;
    
        }

        public  void AddProduct(Product product, int amount, DateTime lastStockDate)
        {
        
            ProductDictionary.Add(new ProductInfo(product, lastStockDate), amount);
        }

        public void GetProductInfo(string productName)
        {

            foreach (var kvp in ProductDictionary)
            {
                if (kvp.Key.product.Name == productName)
                {
                    ShowMyMessage(kvp.Key.product.GetProductInfo());
                    return;

                }
            }
            ShowMyMessage($"Product '{productName}' not found in Warehouse.");
        }
       private void ShowMyMessage(string message)
        {
            if(Message != null)
            {
                Message(this, new ShowMessageEvent(message));
            }
        }
        public  void RemoveProduct(string productName)
        {
       
            foreach (var kvp in ProductDictionary)
            {
                if (kvp.Key.product.Name == productName)
                {
                    ProductDictionary.Remove(kvp.Key);
                    ShowMyMessage($"Product '{productName}' removed from  Warehouse.");
                }
                
            }
        
        }
        public void SendProduct(string productName, int amount)
        {
            foreach (var kvp in ProductDictionary)
            {
                if (kvp.Key.product.Name == productName)
                {
                    if(kvp.Value >= amount)
                    {
                        ProductDictionary[kvp.Key] = kvp.Value - amount;
                        
                        ReportingList.ShippedGoods.Add(new ProductInfo(kvp.Key.product, DateTime.Now), ProductDictionary[kvp.Key]);
                    }
                    if (kvp.Value < amount)
                    {
                        ShowMyMessage($"Don't have enough quantity!");
                    }
                   
                }

            }
        }
    }
}
