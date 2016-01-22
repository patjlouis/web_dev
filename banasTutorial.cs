using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banasTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            //int i = 0;
            //while(i < 10)
            //{
            //    if (i == 7)
            //    {
            //        i++;
            //        continue;
            //    }

            //    if (i == 9)
            //    {
            //        break;
            //    }


            //    if ((i % 2) > 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //    Console.ReadLine();


            //Example 2
            //string guess;

            //do
            //{
            //    Console.WriteLine("I'm thinking of a number");
            //    guess = Console.ReadLine();
            //    if (guess.Equals("15"))
            //    {
            //        Console.WriteLine("Success!");
            //    }

            //} while (!guess.Equals("15"));
            //Console.ReadLine();

            //Eample 3
            //for (int i = 0; i < 10; i++)
            //{
            //    if ((i % 2) > 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //        Console.ReadLine();

            //Exmaple 4
            //string randStr = "Here are some random characters";

            //foreach(char c in randStr)
            //{
            //    Console.WriteLine(c);
            //}
            //Console.ReadLine();


            string sampString = "A bunch of letters";

            Console.WriteLine("is empty " + String.IsNullOrEmpty(sampString));
            Console.WriteLine("is empty " + String.IsNullOrWhiteSpace(sampString));
            Console.WriteLine("Sting length " + sampString.Length);
            Console.WriteLine("Index of bunch " + sampString.IndexOf("bunch"));

            Console.ReadLine();
        }
    }
}
            

