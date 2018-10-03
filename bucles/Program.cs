using System;

namespace bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int num;

            Console.WriteLine("Introduce un número:");
            num = Convert.ToInt32(Console.ReadLine());

            while(i < 11)
            {
                Console.WriteLine(num + " x " + i + "=" + (num * i));
                i++;
            }
        }
    }
}
