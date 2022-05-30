using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanas_CSharp_Class1
{
    public class CSharp_Numbers
    {
        public void MinMaxInt()
        {
            Console.WriteLine("Smallest Integer Value: {0}", int.MinValue);
            Console.WriteLine("Biggest Integer Value: {0}", int.MaxValue);
        }
        public void MinMaxLong()
        {
            Console.WriteLine("Smallest Long Value: {0}", long.MinValue);
            Console.WriteLine("Biggest Long Value: {0}", long.MaxValue);
        }

        public void MinMaxDecimal()
        {
            Console.WriteLine("Smallest Decimal Value: {0}", Decimal.MinValue);
            Console.WriteLine("Biggest Decimal Value: {0}", Decimal.MaxValue);
        }
        public void MinMaxDouble()
        {
            Console.WriteLine("Smallest Double Value: {0}", Double.MinValue);
            Console.WriteLine("Biggest Double Value: {0}", Double.MaxValue.ToString("#"));
        }
        public void MinMaxFloat()
        {
            Console.WriteLine("Smallest Float Value: {0}", float.MinValue);
            Console.WriteLine("Biggest Float Value: {0}", float.MaxValue.ToString("#"));
        }



    }
}
