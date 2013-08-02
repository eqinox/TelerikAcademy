using System;
class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter number in hexadecimal: ");
        string numAsHex = Console.ReadLine();
        string numAsBinary = "";
        for (int i = 0; i < numAsHex.Length; i++)
        {
            switch (numAsHex.Substring(i, 1))
            {
                case "0": numAsBinary += "0000"; 
                    break;
                case "1": numAsBinary += "0001"; 
                    break;
                case "2": numAsBinary += "0010"; 
                    break;
                case "3": numAsBinary += "0011"; 
                    break;
                case "4": numAsBinary += "0100"; 
                    break;
                case "5": numAsBinary += "0101"; 
                    break;
                case "6": numAsBinary += "0110"; 
                    break;
                case "7": numAsBinary += "0111";
                    break;
                case "8": numAsBinary += "1000";
                    break;
                case "9": numAsBinary += "1001";
                    break;
                case "A": numAsBinary += "1010"; 
                    break;
                case "B": numAsBinary += "1011";
                    break;
                case "C": numAsBinary += "1100";
                    break;
                case "D": numAsBinary += "1101"; 
                    break;
                case "E": numAsBinary += "1110";
                    break;
                case "F": numAsBinary += "1111";
                    break;
                default: numAsBinary += ""; break;
            }
        }
        Console.WriteLine(numAsBinary);
    }
}
