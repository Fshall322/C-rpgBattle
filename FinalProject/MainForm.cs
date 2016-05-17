using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        string userChoice = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Choice();
            //MessageBox.Show(Choice());
            Combat_form combat = new Combat_form(userChoice);
            combat.Show();
            MainForm mainForm = new MainForm();
            mainForm.Hide();
        }

        public string Choice()
        {
            

            if (BarbarianButton.Checked == true)
            {
                userChoice = "Barbarian";
            }
            else if (CavalierButton.Checked == true)
            {
                userChoice = "Cavalier";
            }
            else if (KnightButton.Checked == true)
            {
                userChoice = "Knight";
            }
            else if (MageKillerButton.Checked == true)
            {
                userChoice = "MageKiller";
            }
            else if (PaladinButton.Checked == true)
            {
                userChoice = "Paladin";
            }
            else if (RogueButton.Checked == true)
            {
                userChoice = "Rogue";
            }
            else if (WarriorButton.Checked == true)
            {
                userChoice = "Warrior";
            }
            else if (WizardButton.Checked == true)
            {
                userChoice = "Wizards";
            }

            return userChoice;
        }
    }
}
