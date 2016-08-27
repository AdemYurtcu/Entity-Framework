using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EnttityFrameworkExample1
{
    class Context : DbContext
    {
        public  Context() : base("name=con"){
            
        }
        
        public DbSet<Person> Salak { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().Property(p => p.FirstName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Person>().Property(p => p.LastName).HasMaxLength(50).IsRequired();
        }
    }
}
