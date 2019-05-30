using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Labs_80_ASP_Core_Web.Models;

namespace Labs_80_ASP_Core_Web.Pages
{
    public class CustomersModel : PageModel
    {
        public List<Customer> CustomerList = new List<Customer>();

        public void OnGet()
        {
            using (var db = new Northwind())
            {
                //CustomerList = db.Customers.ToList();
                CustomerList = (from c in db.Customers
                                orderby c.Country ascending
                                select c).ToList(); 
            }
        }
    }
}
