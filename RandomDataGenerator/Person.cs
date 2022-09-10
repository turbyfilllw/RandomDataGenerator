using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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
        // init allows object properties to be changed during the act of construction
        // this can allow us to get rid of boiler plate code such as "this.x = x"
        // however you can only set an init property under certain circumstances
        // 1. when you are initiliazing an object
        // 2. inside the instance constructor that contains the type
        // 3. using "with" as an expression initializer
        // 4. inside the property using the init accessor
        // 5. inside attribute usage that has named parameters
        public string FirstName { get; init; }
        public string LastName { get; init; }
        
        public DateTime BirthDate { get; init; }
        private static DateTime start = new DateTime(1942, 1, 1);
        private static DateTime end = new DateTime(2004, 1, 1);
        private int range = (end - start).Days;
        public SSN SSN { get; init; }
        public Phone Phone { get; init; }
        private int index;
        
        public Person()
        {
            Type type = typeof(LastName);
            Array values = type.GetEnumValues(); // returns an array of the values inside of the num
            LastName last = (LastName)random.Next(values.Length);
            index = random.Next(_arrayOfFirstNames.Length); // index is a random number between 0 and the length of the first names array

            FirstName = _arrayOfFirstNames[index];
            LastName = last.ToString();
            Phone = new Phone();
            BirthDate = (start.AddDays(random.Next(range)).AddHours(random.Next(0, 24)).AddMinutes(random.Next(0, 60)).AddSeconds(random.Next(0, 60)));
            SSN = new SSN();
            
        }

        /// <summary>
        /// returns the age of a person
        /// </summary>
        /// <returns>age of person</returns>
        public int Age()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        public void AddDependant()
        {
            
        }

        /// <summary>
        /// overriden toString for clean output
        /// </summary>
        /// <returns>information about the person object</returns>
        public override string ToString()
        {
            return "First Name: " + FirstName + 
                "\nLast Name: " + LastName + 
                "\nPhone: " + Phone + 
                "\nBirthdate: " + BirthDate + 
                "\nAge: " + Age() + 
                "\nSSN: " + SSN.ToString() +
                "\nDependants " + _dependant;
        }
    }
}
