using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu_linq
{
    class User
    {
            public string Name { get; set; }
            public int Age { get; set; }
        
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User { Name = "Sam", Age = 43 });
            users.Add(new User { Name = "Tom", Age = 33 });

            var names = from u in users select u.Name;

            foreach (string n in names)
                Console.WriteLine(n);
            List<User> user = new List<User>();
            users.Add(new User { Name = "Sam", Age = 43 });
            users.Add(new User { Name = "Tom", Age = 33 });

            var items = from u in users
                        select new
                        {
                            FirstName = u.Name,
                            DateOfBirth = DateTime.Now.Year - u.Age
                        };

            foreach (var n in items)
                Console.WriteLine($"{n.FirstName} - {n.DateOfBirth}");
            Console.ReadKey();

        }

        
    
    }
    
            
       
        
}
