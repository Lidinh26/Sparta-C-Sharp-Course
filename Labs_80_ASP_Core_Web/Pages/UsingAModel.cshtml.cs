using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Labs_80_ASP_Core_Web.Pages
{
    public class UsingAModelModel : PageModel
    {
        public string Property01 { get; set; } = "Default Value";

        //ONGET method is not a constrcutor, its a HTML 'get' request
        public void OnGet()
        {
            Property01 = "Here is data passed from the page model into our View";
        }
    }
}