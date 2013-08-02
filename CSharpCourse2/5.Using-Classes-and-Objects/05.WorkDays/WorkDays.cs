/*Write a method that calculates the number of workdays between today and given date, passed as parameter. 
 * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/
using System;
class WorkDays
{
    static void Main()
    {
        Console.Write("Enter date: ");
        int date = int.Parse(Console.ReadLine());
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        DateTime choosenDay = new DateTime(year, month, date);
        DateTime today = DateTime.Today;
        DateTime todayAgain = today;
        DateTime choosenDayAgain = choosenDay;
        DateTime saturday = new DateTime(2013, 7, 20);
        DateTime sunday = new DateTime(2013, 7, 21);
        int workDays = 0;
        while (choosenDay != today)
        {
            if (choosenDay > today)
            {
                today = today.AddDays(1);
                if (today.DayOfWeek == saturday.DayOfWeek)
                {
                    continue;
                }
                if (today.DayOfWeek == sunday.DayOfWeek)
                {
                    continue;
                }
                workDays++;
            }
            else if (choosenDay < today)
            {
                choosenDay = choosenDay.AddDays(1);
                if (choosenDay.DayOfWeek == saturday.DayOfWeek)
                {
                    continue;
                }
                if (choosenDay.DayOfWeek == sunday.DayOfWeek)
                {
                    continue;
                }
                workDays++;
            }
        }
        Console.WriteLine("Work days from {0} to {1} are: {2}", todayAgain.ToString("dd, MMMM, yyyy"), choosenDayAgain.ToString("dd, MMMM, yyyy"),  workDays);
    }
}