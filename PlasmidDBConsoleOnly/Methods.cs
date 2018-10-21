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
    }
}
