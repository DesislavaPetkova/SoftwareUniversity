using System;
using System.Linq;

class Lines
{
    static void Main()
    {

        int[] mass = { 8, 72, 8, 8, 16, 28, 240, 0 };
        int[] bites = { 0, 0, 0, 0, 0, 0, 0, 0, };
        //int n0 = 0;
        //int b1 = 0;
        //int b2 = 0;
        //int b3 = 0;
        //int b4 = 0;
        //int b5 = 0;
        //int b6 = 0;
        //int b7 = 0;
        int nRight;
        int check;
        for (int i = 0; i < mass.Length; i++)
        {
            for (int t = 0; t < 8; t++)
            {
                nRight = mass[i] >> t;
                check = nRight & 1;
                if (check == 1)
                {
                    Console.Write(t);
                }
            }
            Console.WriteLine();
        }
        
        }
      
    }

