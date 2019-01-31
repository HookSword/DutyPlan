namespace DutyPlan.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Leaver> Leavers { get; set; }
        public virtual DbSet<tableState> tableStates { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tableState>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<tableState>()
                .Property(e => e.Category)
                .IsUnicode(false);
        }
    }
}
