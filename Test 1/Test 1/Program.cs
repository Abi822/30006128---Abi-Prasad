using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int numtwo = 0;

            Console.WriteLine("--|This Programe can tell you if your number is odd or even|--\n");


                Console.Write("Enter a whole number between 1 and 1000: ");
                num = Convert.ToInt32(Console.ReadLine());

                numtwo = (num / 2);

                if (numtwo == 0)
                {
                    Console.WriteLine("That number is odd");
                }
                else
                {
                    Console.WriteLine("That number is even");
                }
                Console.ReadLine();
        }
    }
}
