using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlasmidDBConsoleOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plasmiddatenbank V1.0 Konsolenversion");
            Console.WriteLine("Plasmidname eingeben: ");
            string plasmidName = Console.ReadLine();

            string filePath = $"C:\\Users\\Hendrik\\Desktop\\Plasmiddatenbank\\plasmid_{plasmidName}.text";

            Console.WriteLine("Plasmidsequenz eingeben: ");
            string plasmidSequenz = Console.ReadLine();



            File.AppendAllText(filePath, plasmidName);
            File.AppendAllText(filePath, Environment.NewLine);
            File.AppendAllText(filePath, plasmidSequenz);

            string[] plasmid = File.ReadAllLines(filePath);

            Console.WriteLine("Name: " + plasmid[0] + ", Sequenz: " + plasmid[1]);
            Console.ReadLine();
        }
    }
}
