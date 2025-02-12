using PoliceDatabaseProgram.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PoliceDatabaseProgam
{
    public partial class ViewRecords : Form
    {
        private Inventory inventory;
        private string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Naeem\Downloads\OneDrive_2024-12-03\3309 Final Project\PoliceDatabaseProgam\PoliceDatabase.accdb;";

        public ViewRecords(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            LoadCriminals();
        }

        private void LoadCriminals()
        {
            dataGridViewCriminals.Columns.Clear(); // Clear any existing columns
            dataGridViewCriminals.Columns.Add("Status", "Status");
            dataGridViewCriminals.Columns.Add("Year", "Year");
            dataGridViewCriminals.Columns.Add("Category", "Category");
            dataGridViewCriminals.Columns.Add("Suspect", "Name");
            dataGridViewCriminals.Columns.Add("Age", "Age");
            dataGridViewCriminals.Columns.Add("Height", "Height");
            dataGridViewCriminals.Columns.Add("Weight", "Weight");
            dataGridViewCriminals.Columns.Add("Description", "Description");
            dataGridViewCriminals.Columns.Add("Location", "Location");
            dataGridViewCriminals.Rows.Clear(); // Clear existing rows

            var criminals = inventory.GetAllCriminals();

            if (criminals == null || !criminals.Any())
            {
                MessageBox.Show("No criminals available in the inventory.");
                return;
            }

            foreach (var criminal in criminals)
            {
                var row = new DataGridViewRow();
                row.Tag = criminal;
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.IsSolved ? "Case Closed" : "Case Open" });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Year });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Category });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Name });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Age });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Height });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Weight.ToString("F2") });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Description });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Location });
                dataGridViewCriminals.Rows.Add(row);
            }
        }

        private void dataGridViewCriminals_SelectionChanged(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridViewCriminals.CurrentRow != null && dataGridViewCriminals.CurrentRow.Tag != null)
            {
                var selectedCriminal = dataGridViewCriminals.CurrentRow.Tag as Criminal;
                if (selectedCriminal != null)
                {
                    // Populate the textboxes
                    DisplayDetails(selectedCriminal);
                }
            }
            else
            {
                // Clear details if no row is selected
                ClearDetails();
            }
        }

        private void DisplayDetails(Criminal criminal)
        {
            txtCategory.Text = criminal.Category;
            txtName.Text = criminal.Name;
            txtYear.Text = criminal.Year.ToString();
            txtAge.Text = criminal.Age.ToString();
            txtDescription.Text = criminal.Description;
            txtLocation.Text = criminal.Location;
            txtHeight.Text = criminal.Height.ToString();
            txtWeight.Text = criminal.Weight.ToString("F2"); 
            txtAvailable.Text = criminal.IsSolved ? "Case Closed" : "Case Open";

            try
            {
                pictureBoxCarImage.Load(criminal.ImageUrl);
            }
            catch
            {
                pictureBoxCarImage.Image = null;
            }
        }

        private void ClearDetails()
        {
            txtCategory.Text = string.Empty;
            txtName.Text = string.Empty;
            txtYear.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtLocation.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtHeight.Text = string.Empty;
            txtAvailable.Text = string.Empty;
            pictureBoxCarImage.Image = null;
        }

        private void ClearDataGridView()
        {
            dataGridViewCriminals.Rows.Clear();
        }

        private void ViewRecords_Load(object sender, EventArgs e)
        {
            dataGridViewCriminals.ClearSelection();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewCriminals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                var clickedRow = dataGridViewCriminals.Rows[e.RowIndex];
                var selectedCriminal = clickedRow.Tag as Criminal;

                if (selectedCriminal != null)
                {
                    DisplayDetails(selectedCriminal);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the search text from the search textbox
            string searchText = txtSearch.Text.Trim().ToLower();

            // Clear the DataGridView before displaying new results
            dataGridViewCriminals.Rows.Clear();

            // Get all criminals from the inventory
            var criminals = inventory.GetAllCriminals();

            // Check if any criminals match the search criteria
            bool foundCriminals = false;

            // Loop through all the criminals
            foreach (var criminal in criminals)
            {
                // Check if the search text matches any of the criminal properties
                bool matchesCategory = criminal.Category.ToLower().Contains(searchText);
                bool matchesName = criminal.Name.ToLower().Contains(searchText);
                bool matchesYear = criminal.Year.ToString().Contains(searchText);

                if (matchesCategory || matchesName || matchesYear)
                {
                    var row = new DataGridViewRow();
                    row.Tag = criminal;
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.IsSolved ? "Case Closed" : "Case Open" });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Category });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Year });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Name });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Age });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Height });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Weight.ToString("F2") });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Description });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Location });
                    dataGridViewCriminals.Rows.Add(row);
                    foundCriminals = true;
                }
            }

            // If no criminals matched the search criteria, show a message
            if (!foundCriminals)
            {
                MessageBox.Show("No criminals found matching the search criteria.");
            }
        }

        private void RefreshDataGridView()
        {
            // Clear the DataGridView and reload data
            dataGridViewCriminals.Rows.Clear();
            var criminals = inventory.GetAllCriminals();
            foreach (var criminal in criminals)
            {
                var row = new DataGridViewRow();
                row.Tag = criminal;
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.IsSolved ? "Case Closed" : "Case Open" });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Category });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Year });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Name });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Age });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Height });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Weight.ToString("F2") });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Description });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Location });
                dataGridViewCriminals.Rows.Add(row);
            }
        }

        // Open Edit Form
        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            // Open the criminal update form
           EditCriminal updateCriminalForm = new EditCriminal(inventory);
           updateCriminalForm.Show();
        }

        private void dataGridViewCriminals_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                var clickedRow = dataGridViewCriminals.Rows[e.RowIndex];
                var selectedCriminal = clickedRow.Tag as Criminal;

                if (selectedCriminal != null)
                {
                    DisplayDetails(selectedCriminal);
                }
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            // Get the search text from the search textbox
            string searchText = txtSearch.Text.Trim().ToLower();

            // Clear the DataGridView before displaying new results
            dataGridViewCriminals.Rows.Clear();

            // Get all criminals from the inventory
            var criminals = inventory.GetAllCriminals();

            // Check if any criminals match the search criteria
            bool foundCriminals = false;

            // Loop through all the criminals
            for (int i = 0; i < criminals.Count; i++)
            {
                var criminal = criminals[i];

                // Check if the search text matches any of the criminal properties
                bool matchesName = criminal.Name.ToLower().Contains(searchText);
                bool matchesCategory = criminal.Category.ToLower().Contains(searchText);
                bool matchesLocation = criminal.Location.ToLower().Contains(searchText);
                bool matchesDescription = criminal.Description.ToLower().Contains(searchText);
                bool matchesAge = criminal.Age.ToString().Contains(searchText);
                bool matchesWeight = criminal.Weight.ToString().Contains(searchText);
                bool matchesHeight = criminal.Height.ToLower().Contains(searchText);
                bool matchesYear = criminal.Year.ToString().Contains(searchText);
                //Add the criminal to the DataGridView
                if (matchesName || matchesCategory || matchesYear || matchesLocation || matchesHeight || matchesAge || matchesWeight || matchesDescription)
                {
                    var row = new DataGridViewRow();
                    row.Tag = criminals;
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.IsSolved ? "Case Closed" : "Case Open" });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Category });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Year });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Name });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Age });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Height });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Weight.ToString("F2") });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Description });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Location });
                    dataGridViewCriminals.Rows.Add(row);
                    foundCriminals = true;
                }
            }

            // If no criminals matched the search criteria, show a message
            if (!foundCriminals)
            {
                MessageBox.Show("No criminals found matching the search criteria.");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadCriminals(); //Reload the DataGridView
            dataGridViewCriminals.ClearSelection();
        }

        private void btnUpdateCriminal_Click(object sender, EventArgs e)
        {
            // Open the criminal update form
            EditCriminal updateCriminal = new EditCriminal(inventory);
            updateCriminal.Show();

        }
    }
    }

