using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Labs_83_ASP_Core_Add_Records.Models;

namespace Labs_83_ASP_Core_Add_Records.Pages
{
    public class InjectedCustomersModel : PageModel
    {
        private Northwind db;
        public List<Customer> customers;

        //Blind property
        [BindProperty]

        public Customer customer { get; set; }

        //constructer to instantiate this DB
        //Instantiate NorthWind just once : use for get() and post()
        public InjectedCustomersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }
        public void OnGet()
        {
            customers = db.Customers.Skip(20).Take(10).ToList();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToPage("/NorthwindCustomers");
            }
            return Page();
        }
    }
}