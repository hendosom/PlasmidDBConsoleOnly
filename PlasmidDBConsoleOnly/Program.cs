using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlasmidDBConsoleOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plasmiddatenbank V1.0 Konsolenversion");
            Console.WriteLine("Plasmidname eingeben: ");
            string plasmidName=Console.ReadLine();
            Console.WriteLine("Plasmidsequenz eingeben: ");
            string plasmidSequenz = Console.ReadLine();

            Console.WriteLine(plasmidName + " " + plasmidSequenz);
            Console.ReadLine();
        }
    }
}
