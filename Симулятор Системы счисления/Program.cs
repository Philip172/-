using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Симулятор_Системы_счисления
{
    class Program
    {
        static void AddOneToTheNumber(ref int[] number, int power)
        {
            number[0]++;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] >= power)
                {
                    number[i] = 0;

                    if (i < number.Length - 1)
                        number[i + 1]++;
                }
            }
        }

        static void PrintTheNumber(int[] number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (number[i] > 9)
                {
                    Console.Write((char)(55 + number[i]));
                }
                else
                    Console.Write(number[i]);
            }
        }


        static void Main(string[] args)
        {
            int[] number = new int[5];
            int power = 11;

            while (true)
            {
                var gettedKey = Console.ReadKey().Key;
                switch (gettedKey)
                {
                    case ConsoleKey.E:
                        return;

                    case ConsoleKey.OemPlus:
                    case ConsoleKey.Add:
                        AddOneToTheNumber(ref number, power);
                        break;
                }

                Console.WriteLine();
                PrintTheNumber(number);
                Console.WriteLine();
            }
        }
    }
}
