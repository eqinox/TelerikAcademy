using System;
class AsciiTable
{
    static void Main()
    {
        for (int i = 0; i < 127; i++)
        {
            Console.Write("{0}, ", (char)i);
        }
    }
}
