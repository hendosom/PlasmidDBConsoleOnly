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

            Plasmid plasmid = new Plasmid();

            Console.WriteLine("Plasmidname eingeben: ");
            plasmid.name = Console.ReadLine();

            plasmid.filepath = $"C:\\Users\\Hendrik\\Desktop\\Plasmiddatenbank\\plasmid_{plasmid.name}.text";

            Console.WriteLine("Plasmidsequenz eingeben: ");
            plasmid.sequence = Console.ReadLine();



            File.AppendAllText(plasmid.filepath, plasmid.name);
            File.AppendAllText(plasmid.filepath, Environment.NewLine);
            File.AppendAllText(plasmid.filepath, plasmid.sequence);

            string[] plasmidData = File.ReadAllLines(plasmid.filepath);

            Console.WriteLine("Name: " + plasmidData[0] + ", Sequenz: " + plasmidData[1]);
            Console.ReadLine();
        }
    }
}
