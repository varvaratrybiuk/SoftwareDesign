using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ToysWarehouse : Warehouse
    {
        public string Category { get; set; }
        public ToysWarehouse() { }  
        public ToysWarehouse(Product product, int count, DateTime lastStockDate) : base(new Dictionary<ProductInfo, int> { { new ProductInfo(product, lastStockDate), count } })
        {
            Category = "Toys";
        }


    }
}

