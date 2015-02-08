using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EnterNumbers
{
    class EnterNumbers
    {
        public static int ReadNumber(int start, int end)
        {                   
           
            Console.WriteLine("Enter your number in the given range [{0}...{1}]", start, end);
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new ArgumentException("Invalid number");
            }
            
            return number;
        }
        


        static void Main()
        {
            Console.WriteLine("Enter 2 numbers");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    int currentNumber = ReadNumber(start, end);
                    if (currentNumber > start)
                    {
                        start = currentNumber;
                        numbers[i] = start;
                    }
                    else
                    {
                        i--;
                        continue;
                    }
                }
                catch (ArgumentNullException ne)
                {
                    Console.WriteLine("Invalid number");

                }
                catch (OverflowException oe)
                {
                    Console.WriteLine("Invalid number");

                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Invalid number");
                    i--;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
                
            }
        }
    }
}
