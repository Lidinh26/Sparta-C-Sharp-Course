using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;

namespace FinalProject.Pages
{
    public class UserModel : PageModel
    {
        public List<User> UserList;
       
        public User NewUser { get; set; }

        public void OnGet()
        {
            using (var db = new SpartaDatabase())
            {
                UserList = db.User.ToList();
            }
        }

        public IActionResult OnPost()
        {
            using (var db = new SpartaDatabase())
            {
                if (ModelState.IsValid)
                {
                    db.User.Add(NewUser);
                    db.SaveChanges();
                    return RedirectToPage("/User");
                }
            }
            return Page();
        }
    }
}