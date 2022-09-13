using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class Phone
    {
        private Random random = new Random();
        public string Number { get; init; }
        
        // constructor
        public Phone()
        {
            Number = Format();
            
        }

        /// <summary>
        /// turns a 10 digit number into a phone number format
        /// </summary>
        /// <param name="seperator"></param>
        /// <returns>the formatted phone number</returns>
        public string Format(char seperator = '-')
        {
            int[] randomNumbers = new int[10];
            string phoneNumber = "";

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(10);
            }

            if (randomNumbers[0] == 0 || randomNumbers[0] == 1)
            {
                randomNumbers[0] = random.Next(2, 10);
            }

            
            foreach (var phone in randomNumbers)
            {
                phoneNumber += phone;
                
            }

            phoneNumber = phoneNumber.Insert(3, seperator.ToString()).Insert(7, seperator.ToString());

            return phoneNumber;
            
        }

        /// <summary>
        /// overridden tostring
        /// </summary>
        /// <returns>Number</returns>
        public override string ToString()
        {
            return Number;
        }
    }
}
