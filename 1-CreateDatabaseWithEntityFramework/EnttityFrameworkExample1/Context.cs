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
        
        public DbSet<Person> People { get; set; }
    }
}
