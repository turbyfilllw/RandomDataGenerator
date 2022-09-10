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
        private static DateTime start = new DateTime(1942, 1, 1);
        private static DateTime end = new DateTime(2004, 1, 1);
        private int range = (end - start).Days;
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
            BirthDate = (start.AddDays(random.Next(range)).AddHours(random.Next(0, 24)).AddMinutes(random.Next(0, 60)).AddSeconds(random.Next(0, 60)));
        }

        public int Age()
        {
            return DateTime.Now.Year - BirthDate.Year;
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
            return "First Name: " + FirstName + 
                "\nLast Name: " + LastName + 
                "\nPhone: " + Phone + 
                "\nBirthdate: " + BirthDate + 
                "\nAge: " + Age();
        }
    }
}
