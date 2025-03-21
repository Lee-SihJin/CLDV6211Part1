using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace StudRegAppPart2.Models
{
    public partial class RegistrationDBContext : DbContext
    {
        public RegistrationDBContext()
            : base("name=RegistrationDBContext")
        {
        }

        public virtual DbSet<Student01> Student01 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student01>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student01>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Student01>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
