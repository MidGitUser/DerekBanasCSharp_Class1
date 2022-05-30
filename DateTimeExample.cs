using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBans_CSharp_Class1
{
    public class DateTimeExample
    {
        // :1
        DateTime myDate = new DateTime(1994, 8, 14);

        public void dayOfWeek()
        {
            Console.WriteLine("Day of Week: {0}", myDate.DayOfWeek);
        }
        public void addDaysMonthYear()
        {
            Console.WriteLine("Old Date: {0}", myDate.Date);

            myDate = myDate.AddDays(4);
            myDate = myDate.AddMonths(4);
            myDate = myDate.AddYears(4);


            Console.WriteLine("New Date: {0}", myDate.Date);
        }

        // :2
        TimeSpan myTime = new TimeSpan(12, 30, 15);

        public void subtractTimeExample()
        {
            Console.WriteLine("Old Time: {0}", myTime.ToString());
            myTime = myTime.Subtract(new TimeSpan(0, 15 , 0));
            Console.WriteLine("New Time: {0}", myTime.ToString());
        }
        public void addTimeExample()
        {
            Console.WriteLine("Old Time: {0}", myTime.ToString());
            myTime = myTime.Add(new TimeSpan(1, 45, 45));
            Console.WriteLine("New Time: {0}", myTime.ToString());
        }

    }
}
