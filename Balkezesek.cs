//1. lépés
namespace HelloWorld
{
    internal class Balkezesek
    {
        //nev, elso, utolso, suly, magassag
        public string nev;
        public string elso;
        public string utolso;
        public int suly;
        public int magassag;

        public Balkezesek (string Sor)
        {
            var dbok = Sor.Split(';');
            this.nev = dbok[0];
            this.elso = dbok[1];
            this.utolso = dbok[2];
            this.suly = int.Parse(dbok[3]);
            this.magassag = int.Parse(dbok[4]);
        }
    }
}