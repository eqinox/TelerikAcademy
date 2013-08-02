using System;

namespace _09.FloatingPointNumbers
{
    class FloatingPointNumbers
    {
        static void Main()
        {
            float number = float.Parse(Console.ReadLine());
            int sign = 0;

            //Difining and printing "Sign" of the number
            if (number < 0) { sign = 1; number = -1 * number; }

            Console.WriteLine("Sign = {0}", sign);



            //Difining and printing "Exponent" of the number
            Console.Write("Exponent = ");

            int exponent = 0;
            int i = 0;


            for (i = 0; i <= number; i++)   //Count Math.Squre of the number, wihtout loosing of data
            {
                exponent = (int)Math.Pow(2, i);
                if (exponent >= number) { break; }
            }

            exponent = (i - 1) + 127;   //Count "Exponent" ot the number. Exponent(X): x - 124 = Math.Squre of the number

            for (int j = 7; j >= 0; j--)    //Printing the bynary representation of the Exponent(X)
            {
                int multiple = (int)Math.Pow(2, j);
                int digit = (int)(exponent / multiple);
                exponent = exponent % multiple;

                Console.Write(digit);
            }
            Console.WriteLine();

            //Difining and printing "Mantissa" of the number
            Console.Write("Mantissa = ");

            double mantissa = (double)number / Math.Pow(2, i - 1);
            mantissa = mantissa - 1;

            for (i = 1; i < 24; i++)
            {
                double multiple = Math.Pow(2, -i);
                if (mantissa - multiple >= 0)
                {
                    Console.Write(1);
                    mantissa = mantissa - multiple;
                }
                else
                {
                    Console.Write(0);
                }
            }
            Console.WriteLine(); 
        }
    }
}
