using System;

namespace grito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite algo");
            string resposta = Console.ReadLine();
            Console.WriteLine($"{resposta.ToUpper()}");
        }
    }
}
