using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ProductInfo
    {
        public Product product { get; set; } = new Product();
        public DateTime Date { get; set; }
        public ProductInfo() { }
        public ProductInfo(Product product, DateTime Date)
        {
            this.product = product;
            this.Date = Date;
        }

     
    }
}
