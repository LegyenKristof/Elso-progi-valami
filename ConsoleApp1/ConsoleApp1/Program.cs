using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("auto.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] adatok = sor.Split("\t".ToCharArray());
                Auto temp = new Auto(adatok[0], adatok[1], int.Parse(adatok[2]), int.Parse(adatok[3]), adatok[4], int.Parse(adatok[5]));
                Auto.lista.Add(temp);
            }
            sr.Close();

            Console.WriteLine(Auto.DarabSzam());

            Console.ReadLine();
        }
    }
}
