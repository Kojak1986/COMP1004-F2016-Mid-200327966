using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_200327966
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Ran out of time but tried fill the final form load with the characters
        private void FinalForm_Load(object sender, EventArgs e)
        {
            FinalFirstNameTextBox.Text = Program.character.FirstName;
            FinalLastNameTextBox.Text = Program.character.LastName;
            StrengthTextBox.Text = Program.character.Strength;
            CharismaTextBox.Text = Program.character.Charisma;
            DexterityTextBox.Text = Program.character.Dexterity;
            ConstitutionTextBox.Text = Program.character.Constitution;
            WisdomTextBox.Text = Program.character.Wisdom;
            IntelligenceTextBox.Text = Program.character.Intelligence;
            RaceTextBox2.Text = Program.character.Race;
        }
    }
}
