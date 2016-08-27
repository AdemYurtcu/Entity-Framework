using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace ConfiguringPrimitiveProperties
{
    class Context : DbContext
    {
        public  Context() : base("name=con"){
            
        }
        
        public DbSet<Person> PeopleConfigurationClasses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonMap());
        }
    }
}
