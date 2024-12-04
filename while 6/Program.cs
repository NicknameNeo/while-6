using System;

namespace while_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("error");
                return;
                
            }

            int i = 1;
            while (n >= 1)
            {
                i *= n;
                n -= 2;
            }
            
            Console.WriteLine($"Dvoynoy factorial raven {i}");
        }
    }
}