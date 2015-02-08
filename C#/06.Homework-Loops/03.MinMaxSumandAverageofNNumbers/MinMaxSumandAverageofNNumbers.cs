using System;

class MinMaxSumandAverageofNNumbers
{
    static void Main()
    {
        //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below.
        int n = int.Parse(Console.ReadLine());
        int min = 1000;
        int max = 1;
        float sum = 0;
        float avg = 0;        
        for (int i = 0; i < n; i++)
        {
            int raboten = int.Parse(Console.ReadLine());
            if (raboten < min)
            {
                min = raboten;
            }
            else if (raboten > max)
            {
                max = raboten;
            }
            sum = sum + raboten;
            avg = sum / n;
        }
        Console.WriteLine(" min = {0} \n max = {1} \n sum = {2} \n avg = {3:0.00}", min, max, sum, avg);
    }
}

