using System;

namespace factorial_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;

            int fact2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=fact2; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact);

            Console.ReadKey();
        }
    }
}
