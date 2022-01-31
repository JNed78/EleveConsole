using EleveDll;
using System;

namespace EleveConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Eleve el = new Eleve("Jean ", 10, 9);
            Eleve el2 = new Eleve("Pierre ", 5, 13);
            Eleve el3 = new Eleve("Darren ", 15, 18);

            Eleve[] tabel = new Eleve[3];
            tabel[0] = new Eleve("toto", 12.8f, 4);
            tabel[1] = new Eleve("tutu", 15.8f, 1);
            tabel[2] = new Eleve("tata", 16.8f, 8);
            tabel[3] = new Eleve("titi", 17.8f, 10);

            Console.WriteLine(el.afficher());
           


        }
    }
}
