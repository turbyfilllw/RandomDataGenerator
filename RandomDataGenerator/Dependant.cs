using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class Dependant : Person
    {
        private static Random random = new Random();
        public Dependant() 
        {
            start = DateTime.Now;
            end = new DateTime(2032, 9, 10);
            Range = (end - start).Days;
            BirthDate = (start.AddDays(random.Next(Range)).AddHours(random.Next(0, 24)).AddMinutes(random.Next(0, 60)).AddSeconds(random.Next(0, 60)));
        }

        
    }
}
