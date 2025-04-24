using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greatest_of_4
{
    class Find_Greatest
    {
        public decimal FirstNumber { get; set; }

        public decimal SecondNumber { get; set; }

        public decimal ThirdNumber { get; set; }

        public decimal FourthNumber { get; set; }

        decimal GreatestNumber = 0;

        public decimal GreatestOf4()
        {
            Console.WriteLine($"The four numbers are {FirstNumber}, {SecondNumber}, {ThirdNumber} and {FourthNumber}");

            if (FirstNumber >= SecondNumber && FirstNumber >= ThirdNumber)
            {
                if(FirstNumber >= FourthNumber)
                {
                    GreatestNumber = FirstNumber;
                }
                else
                {
                    GreatestNumber = FourthNumber;
                }
            }
            else if (SecondNumber >= ThirdNumber && SecondNumber >= FourthNumber)
            {
                GreatestNumber = SecondNumber;
            }
            else
            {
                GreatestNumber = ThirdNumber;
            }

            return GreatestNumber;
        }

    }
}
