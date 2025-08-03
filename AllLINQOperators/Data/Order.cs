using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AllLINQOperators.Data
{
    internal class Order
    {
        public int OrderID { get; set;}
        public DateTime OrderDate { get; set; }
        public decimal Total{ get; set; }

        public Order(int orderID, DateTime orderDate, decimal total)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            Total = total;
        }

        public Order()
        {
            
        }

        public override string ToString()
            => $"OrderId: {OrderID}, OrderDate: {OrderDate.ToShortDateString()}, Total: {Total}";



    }
}
