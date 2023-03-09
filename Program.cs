//1. lépés
using System.IO;
using System.Text;

namespace HelloWorld
{
    internal class Program
    {
        //2. lépés
        static List<Balkezesek> Balkezes_Lista = new List<Balkezesek>();
        static int bekert;
        static void Main(string[] args)
        {
            Feladat2(); Console.WriteLine();
            Feladat3(); Console.WriteLine();
            Feladat4(); Console.WriteLine();
            Feladat5(); Console.WriteLine();
            
        }

        private static void Feladat6()
        {
            Console.WriteLine("6. Feladat");
            double osszeg = 0;
            int db = 0;
            foreach(var b in Balkezes_Lista)
            {
                if (b.elso.Contains(bekert.ToString()))
                {
                    osszeg += b.suly;
                    db++;
                }
            }
            double Atlagsuly = osszeg / db;
            Console.WriteLine($"A játékosoknak jelenlegi súlya: {Atlagsuly:0.00}");

        }
        private static void Feladat5()
        {
            bekert = 0;
            bool Sikerlt = false;
            while(bekert<1990 || 1999< bekert)
            {
                Console.WriteLine("Adjon meg egy évszámot");
                bekert = int.Parse(Console.ReadLine());
                if(1990<=bekert && bekert <= 1999)
                {
                    Sikerlt = true;
                }
            }
            if(Sikerlt==true)
            { Feladat6(); Console.WriteLine(); }
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