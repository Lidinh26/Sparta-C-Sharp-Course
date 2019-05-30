namespace HW_105_
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ToDoDatabase : DbContext
    {
        public ToDoDatabase()
            : base("name=ToDoDatabase")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Tasks)
                .WithOptional(e => e.Category1)
                .HasForeignKey(e => e.Category);
        }
    }
}
