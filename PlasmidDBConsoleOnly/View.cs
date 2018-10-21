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
        Plasmid plasmidToSave = new Plasmid();
        Plasmid plasmidToLoad = new Plasmid();

        public string InputName { get; set; }
        public string InputSequence { get; set; }

        public View()
        {
            InitializeComponent();
        }

        private void InputPlasmidName_TextChanged(object sender, EventArgs e)
        {
            plasmidToSave.Name = ((TextBox)sender).Text;
        }

        private void InputPlasmidSequence_TextChanged(object sender, EventArgs e)
        {
            plasmidToSave.Sequence = ((TextBox)sender).Text;
        }

        private void ButtonSaveToDB_Click(object sender, EventArgs e)
        {
            if (Methods.FileExistence(plasmidToSave.Filepath) == false)
            {
                LblShowInputName.Text = plasmidToSave.Name;
                LblShowInputSequence.Text = plasmidToSave.Sequence;

                if (Methods.CheckSequence(plasmidToSave.Sequence) == true)
                {
                    Methods.AppendData(plasmidToSave.Filepath, plasmidToSave.Name, plasmidToSave.Sequence);
                }
                else
                {
                    LblDisplayInfoText.Text = "Sequenz enthält ungültige Zeichen. (erlaubt: A, T, G, C, N)";
                }
                

                if (Methods.FileExistence(plasmidToSave.Filepath) == true)
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
            
            string[] a = Methods.LoadData(InputPlasmidNameToLoad.Text);

            plasmidToLoad.Name = a[0];
            plasmidToLoad.Sequence = a[1];

            LblOutputPlasmidName.Text = plasmidToLoad.Name;
            LblOutputPlasmidSequence.Text = plasmidToLoad.Sequence;
        }

        
    }
}
