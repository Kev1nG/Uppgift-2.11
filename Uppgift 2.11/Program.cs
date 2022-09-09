using System;

namespace Uppgift_2._11
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur långt hoppade du Elin?");
            string hoppade = Console.ReadLine();
            Console.WriteLine("jag hoppade runt 10 meter");
            string Elin = Console.ReadLine();
            Console.WriteLine("Hur långt hoppade du då Alma?");
            String hoppade2 = Console.ReadLine();
            Console.WriteLine("Jag hoppade bara 6 meter tyvärr");
            string Alma = Console.ReadLine();
            Console.WriteLine("jag hoppade alltså längre än alma yippii!!");
            string längreElin = Console.ReadLine();
            int x = 10;
            int y = 6;
            int z = 4;
            Console.WriteLine(hoppade + Elin + hoppade2 + Alma);
        }
    }
}