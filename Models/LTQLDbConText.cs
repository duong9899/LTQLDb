using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQLDb.Models
{
    public partial class LTQLDbConText : DbContext
    {
        public LTQLDbConText()
            : base("name=LTQLDbConText")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
