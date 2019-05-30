using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Labs_80_ASP_Core_Web.Pages
{
    public class ListsModel : PageModel
    {
        public List<string> items = new List<string>();
        
        public void OnGet()
        {
            items.Add("First");
            items.Add("Second");
            items.Add("Third");
            items.Add("Fourth");
            items.Add("Fifth");

        }
    }
}