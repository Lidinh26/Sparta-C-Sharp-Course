namespace Labs_93_B
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpartanDatabase")]
    public partial class SpartanDatabase
    {
        [Key]
        public int CourseId { get; set; }

        [StringLength(3)]
        public string Title { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(15)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string University { get; set; }

        [StringLength(25)]
        public string Course { get; set; }
    }
}
