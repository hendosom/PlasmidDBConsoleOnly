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
            if (Methods.FileExistence(plasmid.Filepath) == false)
            {
                LblShowInputName.Text = plasmid.Name;
                LblShowInputSequence.Text = plasmid.Sequence;
                Methods.AppendData(plasmid.Filepath, plasmid.Name, plasmid.Sequence);

                if (Methods.FileExistence(plasmid.Filepath) == true)
                {
                    LblDisplayInfoText.Text = "Plasmid erfolgreich gespeichert!";
                }
            }
            else
            {
                LblDisplayInfoText.Text = "Dieses Plasmid existiert bereits. Bitte wähle einen anderen Namen oder lösche die bestehende Datei.";
            }
            
        }

        private void LblShowInputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblShowInputSequence_TextChanged(object sender, EventArgs e)
        {

        }

        private void View_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblDisplayInfoText_TextChanged(object sender, EventArgs e)
        {
            LblDisplayInfoText.BorderStyle = BorderStyle.FixedSingle;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputPlasmidNameToLoad_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputLoadPlasmid_Click(object sender, EventArgs e)
        {
            Plasmid plasmidToLoad = new Plasmid();
            string[] a = Methods.LoadData(InputPlasmidNameToLoad.Text);
            LblOutputPlasmidName.Text = a[0];
            LblOutputPlasmidSequence.Text = a[1];
        }

        
    }
}
