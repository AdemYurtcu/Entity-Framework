using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnttityFrameworkExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Veri tabanına kayıt ekleme 
            using (Context context = new Context())
            {
                context.Database.CreateIfNotExists();
                Person person = new Person
                {
                    FirstName = "John",
                    LastName = "Doe"
                };
                context.Salak.Add(person);
                
                context.SaveChanges();
            }  
            // Veri tanbanından seçme sorgusu 
            using (Context context = new Context())
            {
                var peoples = context.Salak;
                foreach (var person in peoples)
                {
                    Console.WriteLine("id = {0} - firstname = {1} - lastname = {2}", person.PersonID, person.FirstName, person.LastName);
                }
                Console.ReadKey();
            }
            // Güncelleme İşlemi 
            using (Context context = new Context())
            {
                var peoples = context.Salak;
                if (peoples.Any())
                {
                    var person = peoples.First();
                    person.FirstName = "Adem";
                    person.LastName = "Yurtcu";
                    context.SaveChanges();
                }
            }
            // Silme İşlemi 

            using (Context context = new Context())
            {
                int personId = 2;
                var person = context.Salak.Find(personId);
                if (person != null)
                {
                    context.Salak.Remove(person);
                    context.SaveChanges();
                }
            }
        }
    }
}
