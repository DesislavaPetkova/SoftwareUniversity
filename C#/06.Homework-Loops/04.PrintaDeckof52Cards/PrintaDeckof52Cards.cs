using System;

class PrintaDeckof52Cards
{
    static void Main()
    {
        int a = 5;
        int b = 4;
        int c = 3;
        int d = 6;

        for (int i = 2; i < 15; i++)
        {
            if ((i > 1) && (i < 11))
            {
                Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", i, (char)a, (char)b, (char)c, (char)d);
            }
            else if (i < 12)
            {
                for (int j = 0; j < 5; j++)
                {
                    switch (j)
                    {
                        case 1:
                            {
                                Console.WriteLine("J{0} J{1} J{2} J{3}", (char)a, (char)b, (char)c, (char)d);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Q{0} Q{1} Q{2} Q{3}", (char)a, (char)b, (char)c, (char)d);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("K{0} K{1} K{2} K{3}", (char)a, (char)b, (char)c, (char)d);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("A{0} A{1} A{2} A{3}", (char)a, (char)b, (char)c, (char)d);
                                break;
                            }
                    }
                }
            }
        }
    }
}

