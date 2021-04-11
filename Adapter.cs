using System;

namespace wzorzec6
{
    public interface Czytaj_tekst
    {
        string Czytaj();
    }

    class czyt
    {
        public string czyta_tekst()
        {
            return "da się przeczytać";
        }
    }

    class Adapter : Czytaj_tekst
    {
        private readonly czyt tlumacz;

        public Adapter(czyt tlumacz_tekst)
        {
            this.tlumacz = tlumacz_tekst;
        }

        public string Czytaj()
        {
            return $"To, co było w innym języku '{this.tlumacz.czyta_tekst()}'";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            czyt tekst_w_jezyku = new czyt();
            Czytaj_tekst target = new Adapter(tekst_w_jezyku);

            Console.WriteLine(target.Czytaj());
        }
    }
}