using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {

            try
            {
                int num = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(num));
            }
            catch (ArgumentNullException ax)
            {
                Console.WriteLine("Invalid Number" + ax);
                throw;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid Number");
                throw;
            }
            catch (OverflowException ox)
            {
                Console.WriteLine("Invalid Number");
                throw;
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
            
        }
    }
}
