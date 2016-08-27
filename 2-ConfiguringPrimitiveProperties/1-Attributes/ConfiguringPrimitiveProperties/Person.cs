using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EnttityFrameworkExample1
{
    public class Person
    {
        public int PersonID { get; set; }
        [MaxLength(50,ErrorMessage="FirstName cannot be longer than 50 !")]
        public string FirstName { get; set; }
        [MaxLength(50, ErrorMessage = "LastName cannot be longer than 50 !")]
        public string LastName { get; set; }
    }
}
