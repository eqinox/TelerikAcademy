using System;
class NullValues
{
    static void Main()
    {
        int? intWithNull = null;
        double? doubleWithNull = null;
        Console.WriteLine("{0}", intWithNull + doubleWithNull);
        Console.WriteLine(intWithNull + 1);
        int intWithoutNull = 50;
        double doubleWithoutNull = 100;
        Console.WriteLine("{0}{1}", intWithoutNull, intWithoutNull + intWithNull);
        Console.WriteLine("{0}{1}", doubleWithoutNull, doubleWithoutNull + doubleWithNull);
    }
}