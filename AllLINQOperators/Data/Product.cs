using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLINQOperators.Data
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public override string ToString()
            => $"ProductId : {ProductID}, ProductName: {ProductName}, Category: {Category}, UnitPrice: {UnitPrice}, UnitInStocks: {UnitsInStock}";
    }
}
