using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class Person
    {
        static Random random = new Random();
        private string[] _arrayOfFirstNames = new string[10] 
        {
            "Oda",
            "Johan",
            "Noelle",
            "Chase",
            "Anya",
            "Will",
            "Logan",
            "Tyler",
            "Jason",
            "Mary"
        };
        private Dependant[] _dependant = new Dependant[10];
        
        public string FirstName { get; init; }
        public string LastName { get; init; }
        
        public DateTime BirthDate { get; init; }
        public int SSN { get; init; }
        public Phone Phone { get; init; }
        private int index;
        public Person()
        {
            
            Type type = typeof(LastName);
            Array values = type.GetEnumValues();
            LastName last = (LastName)random.Next(values.Length);
            index = random.Next(_arrayOfFirstNames.Length);

            FirstName = _arrayOfFirstNames[index];
            LastName = last.ToString();
            Phone = new Phone();
        }

        public int Age()
        {
            return 0;
        }

        public void AddDependant()
        {

        }
        private static void GetLastName()
        {
            Type type = typeof(LastName);
            Array values = type.GetEnumValues();

            LastName last = (LastName)random.Next(values.Length);

            Console.WriteLine(last);
        }
        public override string ToString()
        {
            
            return FirstName + " " + LastName + " " + Phone;
            /*return
                FirstName + " \n" +
                LastName + " \n" +
                BirthDate + " \n" +
                SSN + " \n" +
                Phone + " \n";*/
        }
    }
}
