using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if((x == 0 || y == 0) && (x != y))
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
