using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int again = 11;
            int countnum = 1;
            int answer = 0;
            int finalanswer = 0;
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0, num10 = 0;

            for (int i = 1; i < again; i++)
            {
                Console.Write("Enter number {0}: ", countnum);
                if (i == 1)
                {
                    countnum++;                
                    num1 = Convert.ToInt32(Console.ReadLine());
                }
                if (i == 2)
                {
                    countnum++;                
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                if (i == 3)
                {
                    countnum++;                    
                    num3 = Convert.ToInt32(Console.ReadLine());
                }
                if (i == 4)
                {
                    countnum++;                    
                    num4 = Convert.ToInt32(Console.ReadLine());
                }
                if (i == 5)
                {
                    countnum++;                   
                    num5 = Convert.ToInt32(Console.ReadLine());
                }
                if (i == 6)
                {
                    countnum++;                  
                    num6 = Convert.ToInt32(Console.ReadLine());
                }
                if (i == 7)
                {
                    countnum++;                    
                    num7 = Convert.ToInt32(Console.ReadLine());
                }
                if (i == 8)
                {
                    countnum++;                   
                    num8 = Convert.ToInt32(Console.ReadLine());
                }
                if (i == 9)
                {
                    countnum++;                   
                    num9 = Convert.ToInt32(Console.ReadLine());
                }
                if (i == 10)
                {
                    countnum++;                   
                    num10 = Convert.ToInt32(Console.ReadLine());
                }
                if (i == 10)
                {
                    answer = num1 + num2 + num3 + num4 + num5 + num5 + num6 + num7 + num8 + num9 + num10;

                    finalanswer = answer / 10;

                    Console.WriteLine("The Arerage of those ten numbes is: {0}", finalanswer);
                }
            }

            Console.ReadLine();
            
        }
    }
}
