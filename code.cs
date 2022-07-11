using System;
class cantdivideby2
{
    static void Main()
    {
        for (int x = 0; x < 99; x++)
        {
            if (x % 2 != 0)
            {
                Console.WriteLine(x);
            }
        }
        Console.ReadKey(true);
    }
}
