using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBans_CSharp_Class1
{
    public class NumbersExample
    {
        public void currencyExample()
        {
            Console.WriteLine("Currency: {0:c}", 23.455);
        }
        public void PadsExample()
        {
            Console.WriteLine("Pad with 0s: {0:d4}", 23);
        }
        public void DecimalsExample()
        {
            Console.WriteLine("3 Decimals: {0:f3}", 23.4555);
        }
        public void CommasExample()
        {
            Console.WriteLine("Commas: {0:n4}", 2300);
        }


    }
}
