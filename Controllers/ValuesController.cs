using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BAL;
using DAL;
using OrderAssignment.Models;

namespace OrderAssignment.Controllers
{
    public class ValuesController : ApiController
    {
        InvoiceCreation d = new InvoiceCreation ();
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public List<Details>Get(int id)
        {
            List<InvoiceDetails> glist = new List<InvoiceDetails>();
            List<Details> full = new List<Details>();
            glist = d.GetDetails(id);
            foreach (var item in glist)
            {
                Details f = new Details();
                f.CustomerId = item.CustomerId;
                f.CompanyName = item.CompanyName;
                f.City = item.City;
                f.EmployeeId = item.EmployeeId;
                f.OrderDate = item.OrderDate;
                f.OrderId = item.OrderId;
                f.ProductName = item.ProductName;
                f.ProductId = item.ProductId;
                f.UnitPrice = item.UnitPrice;
                f.total =Convert.ToInt32 (item.total);
                f.amount =Convert.ToInt32( item.amount);
                full.Add(f);
            }
            return full;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
