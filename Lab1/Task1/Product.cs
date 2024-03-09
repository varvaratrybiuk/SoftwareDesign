using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.MoneyFolder;

namespace Task1
{
    public class Product
    {
        public string? Name { get; set; }
        public Money Price { get; set; }
        public string? Unit { get; set; }
        public string? Description { get; set; }
        public Product() { 
        }
        public Product(string name, Money price, string unit, string description)
        {
            Name = name;
            Price = price;
            Unit = unit;
            Description = description;
        }

        public void DecreasePrice(float amount)
        {
            Price.Subtract(amount);
        }
        public void IncreasePrice(float amount)
        {
            Price.Add(amount);
        }
        
        public void UpdateProduct(string name, Money price, string unit, string description)
        {
            Name = name;
            Price = price;
            Unit = unit;
            Description = description;
        }
        public string GetProductInfo()
        {
            return $"Name: {Name}" + "\n" + $"Price: {Price.show()}" + "\n" + $"Unit: {Unit}" + "\n" + $"Description: {Description}";
    
        }
    }
}

