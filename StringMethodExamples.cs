using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBans_CSharp_Class1
{
    public class StringMethodExamples
    {
        string myStr = "This is a string";

        public void lenghExample()
        {
            Console.WriteLine("Length of string '{0}' is : {1}", myStr, myStr.Length);
        }
        public void containsExample()
        {
            Console.WriteLine("Is string '{0}' contains 'is'?  {1}", myStr, myStr.Contains("is"));
        }
        public void indexExample()
        {
            Console.WriteLine("Index of 'is' : {0}", myStr.IndexOf("is"));
        }
        public void removeExample()
        {
            Console.WriteLine("Remove String : {0}", myStr.Remove(0, 6));
        }
        public void insertExample()
        {
            Console.WriteLine("Insert String : {0}", myStr.Insert(10, "short "));
        }
        public void replaceExample()
        {
            Console.WriteLine("Replace String : {0}", myStr.Replace("string", "sentence"));
        }
        public void compareExample()
        {
            Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B"), StringComparison.OrdinalIgnoreCase);
        }
        public void equalsExample()
        {
            Console.WriteLine("A = a: {0}", String.Equals("A", "a"), StringComparison.OrdinalIgnoreCase);
        }
        public void padLeftExample()
        {
            Console.WriteLine("Pad Left: {0}", myStr.PadLeft(20, '.'));
        }
        public void padRightExample()
        {
            Console.WriteLine("Pad Right: {0}", myStr.PadRight(20, '.'));
        }
        public void trimExample()
        {
            var str = "       Trim Example             ";
            Console.WriteLine("Trim: {0}", str.Trim());
        }
        public void upperCaseExample()
        {
            Console.WriteLine("UpperCase: {0}", myStr.ToUpper());
        }
        public void lowerCaseExample()
        {
            Console.WriteLine("LowerCase: {0}", myStr.ToLower());
        }
        
        public void StringFormatExample()
        {
            // ** Use "\" to put double quotes inside double quotes
            string newString = String.Format("\"{0}\" saw a \"{1}\" \"{2}\" in the \"{3}\"", "Paul", "rabbit", "eating", "field");

            Console.WriteLine(newString);
        }


    }
}
