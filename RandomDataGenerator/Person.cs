using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class Person
    {

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

        public Person()
        {

        }

        public Person(string FirstName, string LastName, DateTime BirthDate, int SSN, Phone Phone)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.SSN = SSN;
            this.Phone = Phone;
        }

        public int Age()
        {
            return 0;
        }

        public void AddDependant()
        {

        }

        public override string ToString()
        {
            return
                FirstName + " \n" +
                LastName + " \n" +
                BirthDate + " \n" +
                SSN + " \n" +
                Phone + " \n";
        }
    }
}
