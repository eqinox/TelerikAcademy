using System;
class MarketingFirm
{
    public static void SetCursorPosition(int x, int y, char c)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(c);
    }
    static void Main()
    {
        int rows = 40;
        int cols = 17;
        string firstName = "Vasil";
        string lastName = "Nikolov";
        byte age = 19;
        string gender = "Male";
        int iDNumber = 750025348;
        int uniqueEmployeeNumber = 27560000;
        //Console.WriteLine("Name: {0} {1} \nAge:{2} \ngender:{3} \nID:{4}\nUnique Number:{5}",firstName, lastName, age, gender, iDNumber, uniqueEmployeeNumber);

        //left cols
        for (int i = 7; i < cols; i++)
        {
            SetCursorPosition(20, i, '\u258c');
        }
        //left cols

        //top
        SetCursorPosition(20, 7, '_');
        Console.Write(new string('_', rows));
        //top

        //right cols
        for (int i = 8; i < cols; i++)
        {
            SetCursorPosition(61, i, '\u258c');
        }
        //right cols

        //middle cols
        for (int i = 8; i < cols; i++)
        {
            SetCursorPosition(40, i, '\u258c');
        }
        //middle cols

        //bottom
        SetCursorPosition(21, 16, '_');
        Console.Write(new string('_', rows - 2));
        //bottom

        
        
        Console.SetCursorPosition(33, 6);
        Console.Write("Marketing Firm");
        Console.SetCursorPosition(21, 8);
        Console.Write("Name:");
        Console.SetCursorPosition(21, 9);
        Console.Write("Age:");
        Console.SetCursorPosition(21, 10);
        Console.Write("Gender:");
        Console.SetCursorPosition(21, 11);
        Console.Write("ID Number:");
        Console.SetCursorPosition(21, 12);
        Console.Write("Unique Number:");
        Console.SetCursorPosition(41, 8);
        Console.Write("{0} {1}", firstName, lastName);
        Console.SetCursorPosition(41, 9);
        Console.Write("{0}", age);
        Console.SetCursorPosition(41, 10);
        Console.Write("{0}", gender);
        Console.SetCursorPosition(41, 11);
        Console.Write("{0}", iDNumber);
        Console.SetCursorPosition(41, 12);
        Console.Write("{0}", uniqueEmployeeNumber);

        Console.SetCursorPosition(0, 0);
        Console.ReadKey();
        
    }
}
