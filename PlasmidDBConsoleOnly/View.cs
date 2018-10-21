using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlasmidDBConsoleOnly
{
    public partial class View : Form
    {
        Plasmid plasmid = new Plasmid();
        public string InputName { get; set; }
        public string InputSequence { get; set; }

        public View()
        {
            InitializeComponent();
        }

        private void InputPlasmidName_TextChanged(object sender, EventArgs e)
        {
            plasmid.Name = ((TextBox)sender).Text;
        }

        private void InputPlasmidSequence_TextChanged(object sender, EventArgs e)
        {
            plasmid.Sequence = ((TextBox)sender).Text;
        }

        private void ButtonSaveToDB_Click(object sender, EventArgs e)
        {
            LblShowInputName.Text = plasmid.Name;
            LblShowInputSequence.Text = plasmid.Sequence;
            Methods.AppendData(plasmid.Filepath, plasmid.Name, plasmid.Sequence);
        }

        private void LblShowInputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblShowInputSequence_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
