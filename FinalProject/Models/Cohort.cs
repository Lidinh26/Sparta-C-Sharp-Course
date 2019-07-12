using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public partial class Cohort
    {
        public int CohortID { get; set; }
        public string CohortName { get; set; }
        public int SpecialisationID { get; set; }
    }
}
