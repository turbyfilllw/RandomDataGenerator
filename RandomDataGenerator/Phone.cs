using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class Phone
    {
        Random random = new Random();
        public string Number { get; init; }
        
        public Phone()
        {
            for(int i = 0; i < 10; i++)
            {
                Number += random.Next(2, 9);
            }
        }

        public string Format(char seperator = '-')
        {
            return Number.Insert(6, seperator.ToString()).Insert(3,seperator.ToString());
        }

        public override string ToString()
        {
            return Format();
        }
    }
}
