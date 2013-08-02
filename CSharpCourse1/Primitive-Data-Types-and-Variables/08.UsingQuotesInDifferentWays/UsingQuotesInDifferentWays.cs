using System;
class UsingQuotesInDifferentWays
{
    static void Main()
    {
        string firstWaytoTypeQuotes = @"the ""use"" of quatation causes difficulties";
        string secondWayToTypeQuotes = "the \"use\" of quatation causes difficulties";
        Console.WriteLine(firstWaytoTypeQuotes);
        Console.WriteLine(secondWayToTypeQuotes);
    }
}