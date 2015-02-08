using System;

class BinaryDigitsCount
{
    static void Main()
    {
        long B = long.Parse(Console.ReadLine());
        long N = long.Parse(Console.ReadLine());
        for (int z = 0; z < N; z++)
        {

            long P = long.Parse(Console.ReadLine());

            long counter0 = 0;
            long counter1 = 0;
            for (int i = 0; i < 32; i++)
            {
                if (B == 0)
                {
                    long mask = ~P;
                    long nRight = mask >> i;
                    long bit = nRight & 1;
                    if (bit == 1)
                    {
                        if (nRight == -1)
                        {
                            break;
                        }
                        counter1++;
                    }

                }

                else if (B == 1)
                {
                    long nRight = P >> i;
                    long bit = nRight & B;
                    if (bit == 1)
                    {
                        counter0++;
                    }
                }
            }
            if (counter1 > counter0)
            {
                Console.WriteLine(counter1);
            }
            else
            {
                Console.WriteLine(counter0);
            }
        }
    }
}

