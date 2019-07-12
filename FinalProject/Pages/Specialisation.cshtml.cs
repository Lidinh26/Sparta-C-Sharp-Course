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
    public class SpecialisationModel : PageModel
    {
        public List<Specialisation> SpecialisationList;

        public void OnGet()
        {
            using (var db = new SpartaDatabase())
            {
                SpecialisationList = db.Specialisation.ToList();
            }
        }
    }
}
