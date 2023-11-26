using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        for (int i = 0; i <100; i++)
        {
            Console.WriteLine($"номер числа {i}: " + rand.Next());
        }
        Console.ReadKey();
    }
}