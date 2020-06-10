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

        public static int Addition()
        {
            int d = 10;
            int e = 32;
            return d + e;

        }
        static void Main(string[] args)
        {
            

            Console.WriteLine("Hello World!");
            Console.WriteLine("How are you today ?");
            Afficher();
             Afficher();
            Console.WriteLine("That's all folks!!");
            // Test
            int res = Addition();
            Console.WriteLine("resultat = " + res);

        }
    }
}
