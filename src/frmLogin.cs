using PoliceDatabaseProgram.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceDatabaseProgam
{
    public partial class frmLogin : Form
    {
        private DatabaseManagement database;
        private Inventory inventory;
        public frmLogin(Inventory inventory)
        {
            InitializeComponent();
            this.database = new DatabaseManagement();
            this.inventory = inventory;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWarning.Text = string.Empty;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Query database use a passwordValidation program that gives us a boolean

            //if databasemanament.passwordvalidation == true, open menu form and pass along emplyoee id)
            //if false, show incorrect password label and use .update
            string BadgeID = tbBadgeID.Text;
            string password = tbPassword.Text;

            if (database.PasswordValidation(BadgeID, password))
            {
                MainArea MainForm = new MainArea(inventory);
                MainForm.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Incorrect password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lblWarning.Text = "INCORRECT PASSWORD!!!";
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegistration RegistrationForm = new frmRegistration();
            RegistrationForm.ShowDialog();
        }
    }
}
