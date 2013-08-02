/*Write a program that prints to the console which day of the week is today. Use System.DateTime.
*/
using System;
class WhichDayOfWeekIsToday
{
    static void Main()
    {
        DateTime time = DateTime.Now;
        Console.WriteLine(time.DayOfWeek);
    }
}