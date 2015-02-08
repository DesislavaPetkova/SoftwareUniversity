using System;

class FighterAttaack
{
    static void Main()
    {
        int px1 = int.Parse(Console.ReadLine());
        int py1 = int.Parse(Console.ReadLine());
        int px2 = int.Parse(Console.ReadLine());
        int py2 = int.Parse(Console.ReadLine());
        int fx = int.Parse(Console.ReadLine());
        int fy = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int damagecenter = 0;
        int damagetop = 0;
        int damagebottom = 0;
        int damageright = 0;
        int bombx = fx + d;
        int bomby = fy;
        int bombtopx = bombx;
        int bombtopy = bomby + 1;
        int bombbotx = bombx;
        int bombboty = bomby - 1;
        int bombrightx = bombx + 1;
        int bombrighty = bomby;
        int maxX = Math.Max(px1, px2);
        int minX = Math.Min(px1, px2);
        int maxY = Math.Max(py1, py2);
        int minY = Math.Min(py1, py2);

        if ((bombx >= minX && bombx <= maxX) && (bomby <= maxY && bomby >= minY))
        {
            damagecenter += 100;
        }
        if ((bombtopx >= minX && bombtopx <= maxX) && (bombtopy <= maxY && bombtopy >= minY))
        {
            damagetop += 50;
        }
        if ((bombbotx >= minX && bombbotx <= maxX) && (bombboty <= maxY && bombboty >= minY))
        {
            damagebottom += 50;
        }
        if ((bombrightx >= minX && bombrightx <= maxX) && (bombrighty <= maxY && bombrighty >= minY))
        {
            damageright += 75;
        }

        int totaldamage = damageright + damagecenter + damagebottom + damagetop;
        Console.WriteLine(totaldamage + new String('%', 1));

    }
}

