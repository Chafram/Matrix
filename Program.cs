using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//code that display lines of 1s and 0s like in the Matrix movie with some 2s every now and then
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int number = 500; // number of lines
            int length = 119; // width of lines
            int counter = 0;  // counter of total number of digits
            int addTwo = 50;  // add a 2 every X digits

            for (int i = 0; i < number; i++) {
                string line = "";
                for (int j = 0; j < length; j++) {
                    if(counter % addTwo != 0)
                    {
                        line = line + GetRandomNumber(0, 2);
                        counter++;
                    }
                    else
                    {
                        line = line + "2";
                        counter++;
                    }
                }
                Console.WriteLine(line);
                Thread.Sleep(50);
            }
            Console.ReadLine();
        }

        private static Random getRandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            {
                return getRandom.Next(min, max);
            }
        }
    }
}