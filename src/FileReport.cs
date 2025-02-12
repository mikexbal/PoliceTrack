using PoliceDatabaseProgram.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceDatabaseProgam
{
    public partial class FileReport : Form

    {
        private Inventory inventory; 

        public FileReport(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory; // Initialize the inventory
            numYear.Minimum = 1900;
            numYear.Maximum = DateTime.Now.Year;

            // Populate ComboBox with crime categories
            foreach (var category in CrimeCategories.Categories)
            {
                cmbCategory.Items.Add(category);
            }
        }

        private void FileReport_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Get form data
                string category = cmbCategory.SelectedItem?.ToString();
                string name = txtName.Text;
                string height = txtCHeight.Text;
                int year = (int)numYear.Value;
                int age = (int)numAge.Value;
                decimal weight = decimal.Parse(txtWeight.Text);
                bool isSolved = chkIsSolved.Checked;
                string description = txtDescription.Text;
                string location = txtLocation.Text;
                string imageUrl = txtImgUrl.Text;

                // Validate input data
                if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(description) || string.IsNullOrEmpty(location))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                if (age <= 0)
                {
                    MessageBox.Show("Please enter a valid age.");
                    return;
                }

                if (weight <= 0)
                {
                    MessageBox.Show("Please enter a valid weight.");
                    return;
                }

                // Create the Criminal object
                Criminal newCriminal = new Criminal(category, name, year, age, height, weight, isSolved, description, location, imageUrl);

                // Add the criminal to the inventory
                inventory.AddCriminal(newCriminal);

                // Notify the user
                MessageBox.Show("Criminal report successfully added!");

                // Clear the form for the next entry
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            // Clear all input fields and reset default values
            txtName.Clear();
            txtCHeight.Clear();
            numYear.Value = DateTime.Now.Year;
            numAge.Value = 0;
            txtWeight.Clear();
            chkIsSolved.Checked = false;
            txtDescription.Clear();
            txtLocation.Clear();
            txtImgUrl.Clear();
            cmbCategory.SelectedIndex = -1; // Clear ComboBox selection
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle category selection change if needed
        }

        private void numYear_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
