using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos.ConceitosBasicos
{
    public class SistemaTipos
    {
        public string GetName(int ID)
        {
            if (ID < names.Length)
                return names[ID];
            else
                return string.Empty;
        }

        private string[] names = { "Spencer", "Sally", "Doug" };

        public void VisaoGeral()
        {
            // Declaration only:
            float temperature;
            string name;
            SistemaTipos myClass;

            // Declaration with initializers (four examples):
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5 };
            var query = from item in source
                        where item <= limit
                        select item;
        }

        public void TestPerson()
        {
            // var p1 = new Person(); // Error! Required properties not set
            var p2 = new Person() { FirstName = "Grace", LastName = "Hopper" };
        }

        public void TestRecordPerson()
        {
            var phoneNumbers = new string[2];
            RecordPerson person = new("Nancy", "Davolio", phoneNumbers);
            Console.WriteLine(person);

            RecordPerson person1 = new("Nancy", "Davolio", phoneNumbers);
            RecordPerson person2 = new("Nancy", "Davolio", phoneNumbers);
            Console.WriteLine(person1 == person2); // output: True

            person1.PhoneNumbers[0] = "555-1234";
            Console.WriteLine(person1 == person2); // output: True

            Console.WriteLine(ReferenceEquals(person1, person2));

            person2 = person1 with { PhoneNumbers = new string[1] };
            Console.WriteLine(person2);
            // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { };
            Console.WriteLine(person1 == person2); // output: True
        }
    }

    public class Person
    {
        public required string LastName { get; set; }
        public required string FirstName { get; set; }
    }

    public record RecordPerson(string FirstName, string LastName, string[] PhoneNumbers);
}
