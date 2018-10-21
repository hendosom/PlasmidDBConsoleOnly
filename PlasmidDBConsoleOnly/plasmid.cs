using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlasmidDBConsoleOnly
{
    class Plasmid
    {
        public string Name { get; set; }
        public string Sequence { get; set; }
        private string filepath;

        public string Filepath
        {
            get { return filepath = $"C:\\Users\\Hendrik\\Desktop\\Plasmiddatenbank\\plasmid_{Name}.cvs"; }
        }

    }
}
