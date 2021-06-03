using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderAssignment.Models
{
    public class Details
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string ProductName { get; set; }
        public int OrderId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        
        public int ProductId { get; set; }
        public int UnitPrice { get; set; }
        public double amount { get; set; }
        public double total { get; set; }





    }
}