using System;

namespace MyHello
{

    class Program
    {
    
        public static void Afficher()
        {
            Console.WriteLine("Youhouuu");
            int a = 5, b = 32;
            int c = a + b;
            Console.WriteLine(a + "+" + b + "=" + c);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("How are you today ?");
            Afficher();
        }
    }
}
