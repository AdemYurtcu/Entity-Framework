using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConfiguringPrimitiveProperties
{
    public class Person
    {
        public int PersonID { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
