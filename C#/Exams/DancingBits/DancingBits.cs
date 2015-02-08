using System;

class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int counter0 = 0;
        int counter1 = 0;
        string result = null;
        int nRight;
        string reversed = null;
        string concatenation = null;
        int counterk = 0;
        int counterconc = 0;
        for (int i = 0; i < n; i++)
        {
            counter1 = 0;
            counter0 = 0;
            counterconc = 0;
            counterk = 0;
            concatenation = null;
            reversed = null;
            int p = int.Parse(Console.ReadLine());
            for (int t = 0; t < 32; t++)
            {
                nRight = p & 1;
                concatenation = concatenation + nRight;
                p = p >> 1;

                if (p == 0)
                {
                    break;
                }
                counterconc++;
            }
            for (int z = counterconc; z > -1; z--)
            {
                reversed = reversed + concatenation[z];
            }
            result += reversed;
            for (int j = 0; j < result.Length; j++)
            {
                if (result[j] == '1')
                {
                    counter1++;
                    if (counter1 == k)
                    {
                        counterk++;
                        counter1 = 0;
                        
                    }
                }
                //if (counter1 > 3)
                //{
                //counterk--;
                //}
                else if (result[j] == '0')
                {
                    counter1 = 0;
                }

            }
            for (int x = 0; x < result.Length; x++)
            {
                if (result[x] == '0')
                {
                    counter0++;
                    if (counter0 == k)
                    {
                        counterk++;
                        counter0 = 0;
                        
                    }
                }
                //if (counter0 > 3)
                //{
                //    counterk--;
                //}
                else if (result[x] == '1')
                {
                    counter0 = 0;
                }
            }
        }
        Console.WriteLine(counterk);
    }
}

