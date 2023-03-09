//1. lépés
using System.IO;
using System.Text;

namespace HelloWorld
{
    internal class Program
    {
        //2. lépés
        static List<Balkezesek> Balkezes_Lista = new List<Balkezesek>();
        static void Main(string[] args)
        {
            Feladat2();
            Feladat3(); Console.WriteLine();
            Feladat4(); Console.WriteLine();
        }

        private static void Feladat4()
        {
            Console.WriteLine("4. Feladat: 1999. október");
            foreach(var b in Balkezes_Lista)
            {
                double cm = b.magassag * 2.54;
                if (b.utolso.Contains("1999-10"))
                {
                    Console.WriteLine($"név: {b.nev}: {cm}c.");
                }
            }
        }
        private static void Feladat3()
        {
            Console.WriteLine("3. Feladat: Beolvasott sorokszáma: ");
            Console.WriteLine($"A beolvasott sorok száma: {Balkezes_Lista.Count}");
        }
        private static void Feladat2()
        {
            Console.WriteLine("2. Feladat: beolvasás");
            var sr = new StreamReader(@"balkezesek.csv", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                Balkezes_Lista.Add(new Balkezesek(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}