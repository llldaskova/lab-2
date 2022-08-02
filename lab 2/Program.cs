using System;
using System.Collections.Generic;
namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanNumber.Add(new RomanNumber(20), new RomanNumber(10)));
             Console.WriteLine(RomanNumber.Sub(new RomanNumber(20), new RomanNumber(10)));
             Console.WriteLine(RomanNumber.Mul(new RomanNumber(20), new RomanNumber(10)));
             Console.WriteLine(RomanNumber.Div(new RomanNumber(20), new RomanNumber(10)));
             RomanNumber[] romanNumberArray = new RomanNumber[10];
             for (int i = 0; i < 10; i++)
             {
                 romanNumberArray[i] = new RomanNumber((ushort)(new Random().Next(1, ushort.MaxValue)));
                 Console.Write(romanNumberArray[i]+"\n" );
             }
             Console.WriteLine();

             Array.Sort(romanNumberArray);

             for (int i = 0; i < 10; i++)
             {
                 Console.Write(romanNumberArray[i] + "\n");
             }
        }
    }
}
