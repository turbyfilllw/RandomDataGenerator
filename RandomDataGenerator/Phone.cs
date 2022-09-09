using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class Phone
    {
        public string Number { get; init; }

        public Phone()
        {

        }

        public string Format(char seperator = '-')
        {
            return seperator.ToString();
        }
    }
}
