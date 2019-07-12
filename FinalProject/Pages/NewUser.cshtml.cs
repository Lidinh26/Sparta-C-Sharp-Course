using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FinalProject.Models;

namespace FinalProject.Pages
{
    public class NewUserModel : PageModel
    {
        private SpartaDatabase db;
        public List<User> Users;

        [BindProperty]

        public User NewUser { get; set; }

        public NewUserModel(SpartaDatabase injectedcontext)
        {
            db = injectedcontext;
        }

        public void onget()
        {
            Users = db.User.ToList();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                db.User.Add(NewUser);
                db.SaveChanges();
                return RedirectToPage("/User");
            }
            return Page();
        }
    }
}




