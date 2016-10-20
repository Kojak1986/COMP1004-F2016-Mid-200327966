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
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        // generate button calls the generate names and sets the character first name and last
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            
            GenerateNames();

            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
            
        }

        //form load calls the generate names method and sets the character first and last name
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
        }

        //next button brings up the abilities form and hides this one
        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm next = new AbilityGeneratorForm();

            next.Show();
            this.Hide();
        }
    }
}
