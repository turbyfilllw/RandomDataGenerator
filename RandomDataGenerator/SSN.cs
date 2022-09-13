using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    /// <summary>
    /// information i used for invalid ssn number: 
    /// https://primepay.com/blog/how-determine-valid-social-security-number#:~:text=An%20invalid%20SSN%20is%20one,four%20digits%20as%20%E2%80%9C0000.%E2%80%9D
    /// </summary>
    public class SSN
    {
        private static Random random = new Random();
        public string Number { get; init; }
        private static int randomNumber = random.Next(900, 1000);
        private int[] sectionOne = { 000, 666, randomNumber };
        private string sectionTwo = "00";
        private string sectionThree = "0000";
        public SSN()
        {
            
            int index = random.Next(sectionOne.Length);
            Number += sectionOne[index].ToString("000");
            index = random.Next(sectionTwo.Length);
            Number += sectionTwo;
            index = random.Next(sectionThree.Length);
            Number += sectionThree;
        }

        public override string ToString()
        {
            return Number.Insert(3,"-").Insert(6,"-");
        }
    }
}
