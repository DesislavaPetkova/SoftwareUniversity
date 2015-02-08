using System;

class InsideaCircleOutseideRectangle
{
    static void Main()
    {
        Console.WriteLine("Type the coordinates (x and y) to check if your points is inside the circle and outside the rectangle at the same time: ");
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());
        float radius = 1.5f;
        float circlex = x - 1;
        float circley = y - 1;
        bool insideCircle = (circlex * circlex) + (circley * circley) <= (radius * radius);
        //Console.WriteLine(insideCircle);
        bool rectanglepoint = y > 1 || y < -1;
        if (insideCircle == true && rectanglepoint == true)
        {
            Console.WriteLine("The point is inside the circle and outside the rectangle");
        }
        else
        {
            Console.WriteLine("The point is not according the rules probably outside the circle or inside the rectangle");
        }
    }
}

