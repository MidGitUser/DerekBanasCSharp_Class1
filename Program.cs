using DerekBans_CSharp_Class1;
using System;

namespace DerekBanas_CSharp_Class1
{

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            // :2
            // Go to properties > Debug > Enter "Command Line Argument" as '4 5 6 7'
            // ** Command Line arguments is the value of 'args' parameter of Main()

            /*
            // LOOP
            // :3
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg {0} : {1}", i, args[i]);
            }
            */

            /*
            // ARRAY 
            // :4
            // ** Bind Command Line Arguments to an array
            string[] myArgs = Environment.GetCommandLineArgs();

            Console.WriteLine(string.Join(", ", myArgs)); // Join "myArgs" values seperated by ", "
            */
            /*
            // FUNCTIONS
            // :5
            // :5.2
            sayHello();
            */

            /*
            // NUMBERS
            // :6
            CSharp_Numbers obj = new CSharp_Numbers();
            // 6.1 - Int
            obj.MinMaxInt();
            // 6.2 - Long
            obj.MinMaxLong();
            // 6.3 - Decimal
            obj.MinMaxDecimal();
            // 6.4 - Double
            obj.MinMaxDouble();
            // 6.5 - Float
            obj.MinMaxFloat();
            */

            /*
             * 
            // 7 - Parsing Numbers
            bool boolFromString = bool.Parse("true");
            Console.WriteLine(boolFromString);

            int intFromString = int.Parse("100");
            Console.WriteLine(intFromString);

            Double dblFromString = Double.Parse("2.134");
            Console.WriteLine(dblFromString);
            */

            /*
            DateTimeExample obj = new DateTimeExample();
            obj.dayOfWeek();

            obj.addDaysMonthYear();

            obj.subtractTimeExample();
            obj.addTimeExample();
            */

            /*
            // NUMBERS EXAMPLE
            NumbersExample obj = new NumbersExample();
            obj.currencyExample();
            obj.PadsExample();
            obj.DecimalsExample();
            obj.CommasExample();
            */

            // STRING EXAMPLE
            StringMethodExamples obj = new StringMethodExamples();
            obj.lenghExample();
            obj.containsExample();
            obj.indexExample();
            obj.removeExample();
            obj.insertExample();
            obj.replaceExample();
            obj.compareExample();
            obj.equalsExample();
            obj.padLeftExample();
            obj.padRightExample();
            obj.trimExample();
            obj.upperCaseExample();
            obj.lowerCaseExample();
            obj.StringFormatExample();

            // :1
            Console.ReadKey();
        }

        // 5.1
        private static void sayHello()
        {
            string name = "";

            Console.WriteLine("Type your name : ");

            name = Console.ReadLine(); //Get Input

            Console.WriteLine("Hello {0}", name);
        }

    }
}