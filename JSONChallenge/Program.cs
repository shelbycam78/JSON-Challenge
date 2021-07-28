using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();

            person.FirstName = "Phil";
            person.LastName = "McCrackin";
            person.DOB = new DateTime(1994, 10, 2);
            person.FavoriteIceCreamFlavors = new List<string>
            {"strawberry", "Cookie Dough"
            };
            string json = JsonConvert.SerializeObject(person);

            Console.WriteLine(json);

            Console.ReadKey();

        }
    }
}
