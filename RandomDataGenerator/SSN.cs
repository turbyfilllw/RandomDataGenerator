using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class SSN
    {
        public string Number { get; init; }

        public SSN()
        {

        }

        public override string ToString()
        {
            return Number;
        }
    }
}
