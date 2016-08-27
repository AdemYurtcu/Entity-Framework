using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Data.Entity.ModelConfiguration;


namespace ConfiguringPrimitiveProperties
{
    
    class PersonMap: EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            Property(p => p.FirstName).HasMaxLength(30).IsRequired();
            Property(p => p.LastName).HasMaxLength(30).IsRequired();
        }
    }
}
