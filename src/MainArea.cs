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
    

    public partial class MainArea : Form
    {
        //private string badgeID;
        private Inventory inventory;
        public MainArea(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
        }

        private void lblPoliceDatabase_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FileReport fileReportForm = new FileReport(inventory);
            fileReportForm.ShowDialog();
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            // Clear the in-memory inventory
            inventory.ClearInventory();
            // Connection string to Access database
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Naeem\Downloads\OneDrive_2024-12-03\3309 Final Project\PoliceDatabaseProgam\PoliceDatabase.accdb;";


            // Clear the saved inventory in the Access database
            inventory.ClearSavedInventory(connectionString);
            MessageBox.Show("Inventory has been cleared from the database!");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewRecords viewRecords = new ViewRecords(inventory);

            // Show the form
            viewRecords.ShowDialog();
        }
    }
}
