using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Labs_83_ASP_Core_Add_Records.Models;

namespace Labs_83_ASP_Core_Add_Records.Pages
{
    public class NorthwindCustomersModel : PageModel
    {
        public List<Customer> customers;
        public void OnGet()
        {
            using (var db = new Northwind())
            {
                customers = db.Customers.ToList();
            }

        }
    }
}