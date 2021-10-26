using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            char inp;
            int countA = 0, countE = 0, countI = 0, countO = 0, countU = 0;

            Console.Write("Enter any sentence or word: ");
            input = Console.ReadLine().ToLower();
          
            for (int x = 0; x < input.Length; ++x)
            {
                inp = input[x];
                switch (inp)
                {
                    case 'a':
                        ++countA;
                        break;
                    case 'e':
                        ++countE;
                        break;
                    case 'i':
                        ++countI;
                        break;
                    case 'o':
                        ++countO;
                        break;
                    case 'u':
                        ++countU;
                        break;
                }
            }

            Console.WriteLine(input + " contains the following: ");
            Console.WriteLine("A = "+ countA);
            Console.WriteLine("E = " + countE);
            Console.WriteLine("I = " + countI);
            Console.WriteLine("O = " + countO);
            Console.WriteLine("U = " + countU);

            Console.Read();

        }
    }
}