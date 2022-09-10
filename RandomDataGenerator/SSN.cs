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
        private static int validNumber = random.Next(10, 99);
        private int[] sectionOne = { 000, 666, randomNumber, validNumber };
        private int[] sectionTwo = { 00, validNumber };
        private int[] sectionThree = { 0000, validNumber };
        public SSN()
        {
            // i suppose this solution has a small chance of producing a valid ssn
            // but i didnt want sections 2 and 3 to be 00 and 0000 the entire time
            // and section one to be 000, 666, or 900 - 1000 the entire time
            int index = random.Next(sectionOne.Length);
            Number += sectionOne[index].ToString("000");
            Number += "-";
            index = random.Next(sectionTwo.Length);
            Number += sectionTwo[index].ToString("00");
            Number += "-";
            index = random.Next(sectionThree.Length);
            Number += sectionThree[index].ToString("0000");
        }

        public override string ToString()
        {
            return Number;
        }
    }
}
