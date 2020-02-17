using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Auto
    {
        public static List<Auto> lista = new List<Auto>();
        private string márka;
        private string model;
        private int evJarat;
        private int km;
        private string uzemAnyag;
        private int ar;

        public Auto(string márka, string model, int evJarat, int km, string uzemAnyag, int ar)
        {
            this.márka = márka;
            this.model = model;
            this.evJarat = evJarat;
            this.km = km;
            this.uzemAnyag = uzemAnyag;
            this.ar = ar;
        }

        public string Márka { get => márka; set => márka = value; }
        public string Model { get => model; set => model = value; }
        public int EvJarat { get => evJarat; set => evJarat = value; }
        public int Km { get => km; set => km = value; }
        public string UzemAnyag { get => uzemAnyag; set => uzemAnyag = value; }
        public int Ar { get => ar; set => ar = value; }

        public static int DarabSzam()
        {
            return lista.Count();
        }

        public double ToyotaAtlagAr()
        {
            Console.WriteLine();
            double atlag = 0;
            int counter = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (márka == "Toyota")
                {
                    Console.WriteLine("Ár: " + lista[i].ar);
                    atlag += lista[i].ar;
                    counter++;
                }
            }

            return atlag / counter;
        }
    }
}
