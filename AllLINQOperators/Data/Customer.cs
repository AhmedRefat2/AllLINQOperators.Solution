using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLINQOperators.Data
{
    internal class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Order[] Orders { get; set; } // Compostion or Aggregation 
        public Customer(string customerID, string customerName)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            Orders = new Order[10];
        }
        public Customer()
        {

        }
        public override string ToString()
            => $"{CustomerID}, {CustomerName}, {Address}, {City}, {Region}, {PostalCode}, {Country}, {Phone}, {Fax}";
    }
}
