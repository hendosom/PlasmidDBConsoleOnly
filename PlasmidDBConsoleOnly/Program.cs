using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PlasmidDBConsoleOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            View view = new View();
            Application.Run(view);
            
            
            // Methods methods = new Methods();

            // Console.WriteLine("Plasmiddatenbank V1.0 Konsolenversion");
            // Console.WriteLine("Plasmidname eingeben: ");
            // plasmid.Name = Console.ReadLine();

            // plasmid.Filepath = $"C:\\Users\\Hendrik\\Desktop\\Plasmiddatenbank\\plasmid_{plasmid.Name}.text";

            // Console.WriteLine("Plasmidsequenz eingeben: ");
            // plasmid.Sequence = Console.ReadLine();



            

            // string[] plasmidData = File.ReadAllLines(plasmid.Filepath);

            // Console.WriteLine("Name: " + plasmidData[0] + ", Sequenz: " + plasmidData[1]);
            // Console.ReadLine();
        }
    }
}
