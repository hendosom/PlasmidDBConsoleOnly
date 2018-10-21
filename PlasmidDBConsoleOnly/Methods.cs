using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlasmidDBConsoleOnly
{
    static class Methods
    {
        static public void AppendData(string a, string b, string c)
        {

            File.AppendAllText(a, b);
            File.AppendAllText(a, Environment.NewLine);
            File.AppendAllText(a, c);
        }

        static public string[] LoadData(string a)
        {
            string[] b = new string[2];
            string filepath = $"C:\\Users\\Hendrik\\Desktop\\Plasmiddatenbank\\plasmid_{a}.text";

            if (File.Exists(filepath))
            {
                b = File.ReadAllLines(filepath); //
            }

            else
            {
                b[0] = "File not found.";
            }

            return b;
        }

        static public bool FileExistence(string a)
        {
            bool result = false;

            if (File.Exists(a))
            {
                result = true;
            }

            return result;
        }
    }
}
