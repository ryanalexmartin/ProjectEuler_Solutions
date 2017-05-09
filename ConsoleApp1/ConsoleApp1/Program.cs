using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program            // NEED BETTER UNDERSTANDING OF BASIC PRINCIPLES OF COMPUTER SCIENCE AND MATHEMATICS RELATED TO IT
    {
        static public int divNum;

        public static void Main()
        {
            Factor(28);
            
            
        }

        public static string Factor(int arg)
        {
            divNum = arg;

            int  moduloSmooth = divNum / 2;  //Highest possible divisor number (smoothing)


            if (divNum % moduloSmooth == 0)  //    -----NOT A PRIME NUMBER, move to the next one
            {
                divNum = divNum - 1;
                Factor(divNum);





                // recursively subtract down the line.
                
                // Until moduloSmooth < 2
            }

            if(moduloSmooth < 2) // go to the next modulo number, not divisible by any of our divisors
            {
                divNum = arg;
                moduloSmooth = moduloSmooth - 1;
                if (moduloSmooth < 2)
                {
                    divNum = divNum - 1;
                    Factor(divNum);
                    

                }
                



            }
            else
            {
                Console.Write("" + divNum + " is the largest prime factor");

            }

            Console.Read();

            return "end";



        }
    }
}
