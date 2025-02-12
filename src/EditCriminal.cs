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
    public partial class EditCriminal : Form
    {
        private Inventory inventory;
        private string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Naeem\Downloads\OneDrive_2024-12-03\3309 Final Project\PoliceDatabaseProgam\PoliceDatabase.accdb;";
        public EditCriminal(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            LoadCriminals();
        }

        private void EditCriminal_Load(object sender, EventArgs e)
        {

        }


        //Load


        private void LoadCriminals()
        {
            // Clear any existing columns and rows
            dataGridViewCriminals.Columns.Clear();
            dataGridViewCriminals.Rows.Clear();

            // Define columns for the DataGridView
            dataGridViewCriminals.Columns.Add("Name", "Name");
            dataGridViewCriminals.Columns.Add("Age", "Age");
            dataGridViewCriminals.Columns.Add("Height", "Height");
            dataGridViewCriminals.Columns.Add("Weight", "Weight");
            dataGridViewCriminals.Columns.Add("Year", "Year");
            dataGridViewCriminals.Columns.Add("Status", "Status");
            dataGridViewCriminals.Columns.Add("Location", "Location");
            dataGridViewCriminals.Columns.Add("Description", "Description");
            


            // Get all criminals 
            var criminals = inventory.GetAllCriminals();

            // Check if there are any criminals available
            if (criminals == null || !criminals.Any())
            {
                MessageBox.Show("No criminals available in the inventory.");
                return;
            }


            foreach (var criminal in criminals)
            {
                var row = new DataGridViewRow();
                row.Tag = criminal;  // Store the criminal object in the Tag property of the row

                // Add cells for each column
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Name });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Age });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Height });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Weight.ToString("C") });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Year });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.IsSolved ? "Case Closed" : "Case Open" });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Location });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = criminal.Description });
                

                // Add the row to the DataGridView
                dataGridViewCriminals.Rows.Add(row);
            }
        }


        private void UpdateCriminalStatusInDatabase(Criminal criminal)
        {
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Naeem\\Documents\\CriminalRental.accdb";

            using (var connection = new OleDbConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Update the IsSolved value in the database for the specified criminal
                    string query = $"UPDATE Criminals SET IsSolved = {criminal.IsSolved} WHERE Id = {criminal.Id}";
                    var command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                }
            }
        }




        private void btnUpdateName_Click(object sender, EventArgs e)
        {// Check if a row is selected
            if (dataGridViewCriminals.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridViewCriminals.CurrentRow;

                // Extract the criminal 
                var selectedCriminal = selectedRow.Tag as Criminal;

                if (selectedCriminal == null)
                {
                    MessageBox.Show("Selected criminal information is not valid.");
                    return;
                }

                // Get the criminal from the textbox
                string newName = txtBoxUName.Text;

                // Validate
                if (string.IsNullOrWhiteSpace(newName))
                {
                    MessageBox.Show("Please enter a valid entry.");
                    return;
                }


                MessageBox.Show("Name information updated successfully.");
                UpdateCriminalName(selectedCriminal.Id, newName);


                selectedRow.Cells["Name"].Value = newName;
            }
            else
            {
                MessageBox.Show("Please select a criminal to update.");
            }
        }
        private void UpdateCriminalName(int criminalId, string newName)
        {
            string updateQuery = $"UPDATE Criminals SET Name = '{newName}' WHERE ID = {criminalId}";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Name updated successfully.");

                            // Update the criminal directly in the DataGridView
                            foreach (DataGridViewRow row in dataGridViewCriminals.Rows)
                            {
                                if (row.Tag is Criminal criminal && criminal.Id == criminalId)
                                {
                                    row.Cells["Name"].Value = newName; // Update the Name cell
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating criminal: " + ex.Message);
                }
            }
        }




        private void btnUpdateAge_Click(object sender, EventArgs e)
        {

            // Check if a row is selected
            if (dataGridViewCriminals.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridViewCriminals.CurrentRow;

                var selectedCriminal = selectedRow.Tag as Criminal;

                if (selectedCriminal == null)
                {
                    MessageBox.Show("Selected criminal information is not valid.");
                    return;
                }

                // Get the age from the textbox
                string ageText = txtAge.Text;

                // Validate the age input
                if (string.IsNullOrWhiteSpace(ageText) || !int.TryParse(ageText, out int newAge))
                {
                    MessageBox.Show("Please enter a valid age.");
                    return;
                }

                MessageBox.Show("Age information updated successfully.");
                UpdateCriminalAge(selectedCriminal.Id, newAge);

                // Update the age directly in the DataGridView
                selectedRow.Cells["Age"].Value = newAge;  // Update the age cell in the grid

            }
            else
            {
                MessageBox.Show("Please select a criminal to update.");
            }
        }

        private void UpdateCriminalAge(int criminalId, int newAge)
        {
            string updateQuery = $"UPDATE Criminals SET Age = {newAge} WHERE ID = {criminalId}";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Age updated successfully.");

                            // Update the age directly in the DataGridView
                            foreach (DataGridViewRow row in dataGridViewCriminals.Rows)
                            {
                                if (row.Tag is Criminal criminal && criminal.Id == criminalId)
                                {
                                    row.Cells["Age"].Value = newAge; // Update the Age cell
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }


        private void btnRecordDescription_Click(object sender, EventArgs e)
        {

            // Check if a row is selected in the DataGridView
            if (dataGridViewCriminals.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridViewCriminals.CurrentRow;

                var selectedCriminal = selectedRow.Tag as Criminal;

                if (selectedCriminal == null)
                {
                    MessageBox.Show("Selected criminal information is not valid.");
                    return;
                }

                // Get the description information from the textbox
                string descriptionInfo = descriptionInfoTextBox.Text;

                // If no description info is entered, default it to "None"
                if (string.IsNullOrWhiteSpace(descriptionInfo))
                {
                    descriptionInfo = "None";
                }

                // Update the description information in the database
                UpdateCriminalDescription(selectedCriminal.Id, descriptionInfo);


                selectedRow.Cells["Description"].Value = descriptionInfo;

                MessageBox.Show("Description information updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a criminal to record description.");
            }

        }

        private void UpdateCriminalDescription(int criminalId, string descriptionInfo)
        {
            // Update the description information in the database
            string updateQuery = $"UPDATE Criminals SET Description = '{descriptionInfo}' WHERE ID = {criminalId}";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        // Execute the update query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Show success message
                            MessageBox.Show("Description information updated successfully.");

                            // Update the description information directly in the DataGridView
                            foreach (DataGridViewRow row in dataGridViewCriminals.Rows)
                            {
                                if (row.Tag is Criminal criminal && criminal.Id == criminalId)
                                {
                                    row.Cells["Description"].Value = descriptionInfo;  // Update the Description cell
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void bttnUHeight_Click(object sender, EventArgs e)
        {

            if (dataGridViewCriminals.CurrentRow != null)
            {
                var selectedCriminal = dataGridViewCriminals.CurrentRow.Tag as Criminal;
                if (selectedCriminal != null)
                {
                    string newHeight = txtBoxUHeight.Text;
                    if (!string.IsNullOrWhiteSpace(newHeight))
                    {
                        // Update the height in the database
                        UpdateCriminalHeight(selectedCriminal.Id, newHeight);
                        MessageBox.Show("Height updated successfully.");

                        // Update the height in the criminal object
                        selectedCriminal.Height = newHeight;

                        dataGridViewCriminals.CurrentRow.Cells["Height"].Value = newHeight;
                    }
                }
            }

        }

        private void UpdateCriminalHeight(int criminalId, string newHeight)
        {
            string updateQuery = $"UPDATE Criminals SET Height = '{newHeight}' WHERE ID = {criminalId}";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Height updated successfully.");

                            // Update the height directly in the DataGridView
                            foreach (DataGridViewRow row in dataGridViewCriminals.Rows)
                            {
                                if (row.Tag is Criminal criminal && criminal.Id == criminalId)
                                {
                                    row.Cells["Height"].Value = newHeight; // Update the Height cell
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }




        private void bttnUYear_Click(object sender, EventArgs e)
        { // Check if a row is selected
            if (dataGridViewCriminals.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridViewCriminals.CurrentRow;

                // Extract the criminal 
                var selectedCriminal = selectedRow.Tag as Criminal;

                if (selectedCriminal == null)
                {
                    MessageBox.Show("Selected criminal information is not valid.");
                    return;
                }

                // Get the year from the textbox
                string yearText = txtBoxUYear.Text;

                // Validate the year input
                if (string.IsNullOrWhiteSpace(yearText) || !int.TryParse(yearText, out int newYear))
                {
                    MessageBox.Show("Please enter a valid year.");
                    return;
                }

                MessageBox.Show("Year information updated successfully.");
                UpdateCriminalYear(selectedCriminal.Id, newYear);

                // Update the year directly in the DataGridView
                selectedRow.Cells["Year"].Value = newYear;  // Update the Year cell in the grid
            }
            else
            {
                MessageBox.Show("Please select a criminal to update.");
            }
        }

        private void UpdateCriminalYear(int criminalId, int newYear)
        {
            string updateQuery = $"UPDATE Criminals SET Year = {newYear} WHERE ID = {criminalId}";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Year updated successfully.");

                            // Update the year directly in the DataGridView
                            foreach (DataGridViewRow row in dataGridViewCriminals.Rows)
                            {
                                if (row.Tag is Criminal criminal && criminal.Id == criminalId)
                                {
                                    row.Cells["Year"].Value = newYear; // Update the Year cell
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void bttnULocation_Click(object sender, EventArgs e)
        {// Check if a row is selected
            if (dataGridViewCriminals.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridViewCriminals.CurrentRow;

                // Extract the criminal 
                var selectedCriminal = selectedRow.Tag as Criminal;

                if (selectedCriminal == null)
                {
                    MessageBox.Show("Selected criminal information is not valid.");
                    return;
                }

                // Get the location from the textbox
                string newLocation = txtBoxULocation.Text;

                // Validate the location input
                if (string.IsNullOrWhiteSpace(newLocation))
                {
                    MessageBox.Show("Please enter a valid location.");
                    return;
                }

                MessageBox.Show("Location information updated successfully.");
                UpdateCriminalLocation(selectedCriminal.Id, newLocation);

                // Update the location directly in the DataGridView
                selectedRow.Cells["Location"].Value = newLocation;  // Update the Location cell in the grid
            }
            else
            {
                MessageBox.Show("Please select a criminal to update.");
            }
        }

        private void UpdateCriminalLocation(int criminalId, string newLocation)
        {
            string updateQuery = $"UPDATE Criminals SET Location = '{newLocation}' WHERE ID = {criminalId}";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Location updated successfully.");

                            // Update the location directly in the DataGridView
                            foreach (DataGridViewRow row in dataGridViewCriminals.Rows)
                            {
                                if (row.Tag is Criminal criminal && criminal.Id == criminalId)
                                {
                                    row.Cells["Location"].Value = newLocation; // Update the Location cell
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void bttnUWeight_Click(object sender, EventArgs e)
        { // Check if a row is selected
            if (dataGridViewCriminals.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridViewCriminals.CurrentRow;

                // Extract the criminal
                var selectedCriminal = selectedRow.Tag as Criminal;

                if (selectedCriminal == null)
                {
                    MessageBox.Show("Selected criminal information is not valid.");
                    return;
                }

                // Get the weight from the textbox
                string weightText = txtBoxUWeight.Text;

                // Validate the weight input
                if (string.IsNullOrWhiteSpace(weightText) || !decimal.TryParse(weightText, out decimal newWeight) || newWeight <= 0)
                {
                    MessageBox.Show("Please enter a valid weight.");
                    return;
                }

                MessageBox.Show("Weight information updated successfully.");
                UpdateCriminalWeight(selectedCriminal.Id, newWeight);

                // Update the weight directly in the DataGridView
                selectedRow.Cells["Weight"].Value = newWeight.ToString("C");  // Update the weight cell in the grid
            }
            else
            {
                MessageBox.Show("Please select a criminal to update.");
            }
        }

        private void UpdateCriminalWeight(int criminalId, decimal newWeight)
        {
            string updateQuery = $"UPDATE Criminals SET Weight = {newWeight} WHERE ID = {criminalId}";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Weight updated successfully.");

                            // Update the weight directly in the DataGridView
                            foreach (DataGridViewRow row in dataGridViewCriminals.Rows)
                            {
                                if (row.Tag is Criminal criminal && criminal.Id == criminalId)
                                {
                                    row.Cells["Weight"].Value = newWeight.ToString("C"); // Update the Weight cell
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void bttnChangeAvailability_Click(object sender, EventArgs e)
        {
            var selectedCriminal = dataGridViewCriminals.CurrentRow.Tag as Criminal;
            if (selectedCriminal != null)
            {
                // Check the current availability status of the criminal
                if (!selectedCriminal.IsSolved)
                {
                    // If the criminal is not available, mark it as available
                    selectedCriminal.IsSolved = true;

                    // Update the database with this change
                    UpdateCriminalStatusInDatabase(selectedCriminal);
                    dataGridViewCriminals.CurrentRow.Cells["Status"].Value = "Case Closed";
                }
                else
                {
                    MessageBox.Show("The case is already closed.");
                }

                // Reload the criminals
               // LoadCriminals();
            }
        }




        private void submitButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewCriminals.CurrentRow != null)
            {
                var selectedCriminal = dataGridViewCriminals.CurrentRow.Tag as Criminal;
                if (selectedCriminal != null)
                {

                    string ageText = txtAge.Text;
                    if (!string.IsNullOrWhiteSpace(ageText) && int.TryParse(ageText, out int newAge))
                    {
                        //Handling Age
                        UpdateCriminalAge(selectedCriminal.Id, newAge);
                        selectedCriminal.Age = newAge;
                        dataGridViewCriminals.CurrentRow.Cells["Age"].Value = newAge;
                    }


                    // Update Name
                    string criminal = txtBoxUName.Text;
                    UpdateCriminalName(selectedCriminal.Id, criminal);
                    selectedCriminal.Name = criminal;
                    dataGridViewCriminals.CurrentRow.Cells["Name"].Value = criminal;

                    // Update Height
                    string height = txtBoxUHeight.Text;
                    UpdateCriminalHeight(selectedCriminal.Id, height);
                    selectedCriminal.Height = height;
                    dataGridViewCriminals.CurrentRow.Cells["Height"].Value = height;

                    // Update Year
                    string yearText = txtBoxUYear.Text;
                    if (int.TryParse(yearText, out int year))
                    {
                        UpdateCriminalYear(selectedCriminal.Id, year);
                        selectedCriminal.Year = year;
                        dataGridViewCriminals.CurrentRow.Cells["Year"].Value = year;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid year.");
                    }

                    // Update Location
                    string location = txtBoxULocation.Text;
                    UpdateCriminalLocation(selectedCriminal.Id, location);
                    selectedCriminal.Location = location;
                    dataGridViewCriminals.CurrentRow.Cells["Location"].Value = location;

                    // Update Rental Price Per Day 
                    string weightText = txtBoxUWeight.Text;
                    if (decimal.TryParse(weightText, out decimal weight))

                    {
                        UpdateCriminalWeight(selectedCriminal.Id, weight);
                        selectedCriminal.Weight = weight;
                        dataGridViewCriminals.CurrentRow.Cells["Weight"].Value = weight.ToString("C");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid weight.");
                    }

                    // Handle Description Update
                    string descriptionInfo = descriptionInfoTextBox.Text;
                    if (string.IsNullOrWhiteSpace(descriptionInfo))
                    {
                        descriptionInfo = "None";
                    }

                    // Update description info in the database
                    UpdateCriminalDescription(selectedCriminal.Id, descriptionInfo);

                    // Update description info in the DataGridView
                    selectedCriminal.Description = descriptionInfo;
                    dataGridViewCriminals.CurrentRow.Cells["Description"].Value = descriptionInfo;


                    // Update the database
                    UpdateCriminalStatusInDatabase(selectedCriminal);



                    MessageBox.Show($"The criminal {selectedCriminal.Name} {selectedCriminal.Height} has been successfully updated.");
                }
            }
            else
            {
                MessageBox.Show("Please select a criminal to return.");
            }
        }



        private void DeleteCriminalFromDatabase(int criminalId)
        {
            string deleteQuery = $"DELETE FROM Criminals WHERE ID = {criminalId}";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Criminal deleted successfully from the database.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting criminal: " + ex.Message);
                }
            }
        }

        private void btnDeleteCriminal_Click(object sender, EventArgs e)
        {
            if (dataGridViewCriminals.CurrentRow?.Tag is Criminal selectedCriminal)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {selectedCriminal.Name} {selectedCriminal.Height}?",
                                             "Confirm Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Delete the criminal from the database
                    DeleteCriminalFromDatabase(selectedCriminal.Id);

                    // Check if deletion was successful
                    if (dataGridViewCriminals.CurrentRow != null)
                    {

                        dataGridViewCriminals.Rows.Remove(dataGridViewCriminals.CurrentRow);
                        MessageBox.Show("Criminal successfully deleted from the inventory and database.");
                    }



                }
            }
            else
            {
                MessageBox.Show("Please select a valid criminal to delete.");
            }

        }

        private void dataGridViewCriminals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateAge_Click_1(object sender, EventArgs e)
        {

            // Check if a row is selected
            if (dataGridViewCriminals.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridViewCriminals.CurrentRow;

                var selectedCriminal = selectedRow.Tag as Criminal;

                if (selectedCriminal == null)
                {
                    MessageBox.Show("Selected criminal information is not valid.");
                    return;
                }

                // Get the age from the textbox
                string ageText = txtAge.Text;

                // Validate the age input
                if (string.IsNullOrWhiteSpace(ageText) || !int.TryParse(ageText, out int newAge))
                {
                    MessageBox.Show("Please enter a valid age.");
                    return;
                }

                MessageBox.Show("Age information updated successfully.");
                UpdateCriminalAge(selectedCriminal.Id, newAge);

                // Update the age directly in the DataGridView
                selectedRow.Cells["Age"].Value = newAge;  // Update the age cell in the grid

            }
            else
            {
                MessageBox.Show("Please select a criminal to update.");
            }

        }

        private void btnRecordDescription_Click_1(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridViewCriminals.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridViewCriminals.CurrentRow;

                var selectedCriminal = selectedRow.Tag as Criminal;

                if (selectedCriminal == null)
                {
                    MessageBox.Show("Selected criminal information is not valid.");
                    return;
                }

                // Get the description information from the textbox
                string descriptionInfo = descriptionInfoTextBox.Text;

                // If no description info is entered, default it to "None"
                if (string.IsNullOrWhiteSpace(descriptionInfo))
                {
                    descriptionInfo = "None";
                }

                // Update the description information in the database
                UpdateCriminalDescription(selectedCriminal.Id, descriptionInfo);


                selectedRow.Cells["Description"].Value = descriptionInfo;

                MessageBox.Show("Description information updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a criminal to record description.");
            }


        }

        private void bttnUHeight_Click_1(object sender, EventArgs e)
        {

            if (dataGridViewCriminals.CurrentRow != null)
            {
                var selectedCriminal = dataGridViewCriminals.CurrentRow.Tag as Criminal;
                if (selectedCriminal != null)
                {
                    string newHeight = txtBoxUHeight.Text;
                    if (!string.IsNullOrWhiteSpace(newHeight))
                    {
                        // Update the height in the database
                        UpdateCriminalHeight(selectedCriminal.Id, newHeight);
                        MessageBox.Show("Height updated successfully.");

                        // Update the height in the criminal object
                        selectedCriminal.Height = newHeight;

                        dataGridViewCriminals.CurrentRow.Cells["Height"].Value = newHeight;
                    }
                }
            }


        }

        private void bttnUYear_Click_1(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewCriminals.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridViewCriminals.CurrentRow;

                // Extract the criminal 
                var selectedCriminal = selectedRow.Tag as Criminal;

                if (selectedCriminal == null)
                {
                    MessageBox.Show("Selected criminal information is not valid.");
                    return;
                }

                // Get the year from the textbox
                string yearText = txtBoxUYear.Text;

                // Validate the year input
                if (string.IsNullOrWhiteSpace(yearText) || !int.TryParse(yearText, out int newYear))
                {
                    MessageBox.Show("Please enter a valid year.");
                    return;
                }

                MessageBox.Show("Year information updated successfully.");
                UpdateCriminalYear(selectedCriminal.Id, newYear);

                // Update the year directly in the DataGridView
                selectedRow.Cells["Year"].Value = newYear;  // Update the Year cell in the grid
            }
            else
            {
                MessageBox.Show("Please select a criminal to update.");
            }

        }

        private void bttnULocation_Click_1(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewCriminals.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridViewCriminals.CurrentRow;

                // Extract the criminal 
                var selectedCriminal = selectedRow.Tag as Criminal;

                if (selectedCriminal == null)
                {
                    MessageBox.Show("Selected criminal information is not valid.");
                    return;
                }

                // Get the location from the textbox
                string newLocation = txtBoxULocation.Text;

                // Validate the location input
                if (string.IsNullOrWhiteSpace(newLocation))
                {
                    MessageBox.Show("Please enter a valid location.");
                    return;
                }

                MessageBox.Show("Location information updated successfully.");
                UpdateCriminalLocation(selectedCriminal.Id, newLocation);

                // Update the location directly in the DataGridView
                selectedRow.Cells["Location"].Value = newLocation;  // Update the Location cell in the grid
            }
            else
            {
                MessageBox.Show("Please select a criminal to update.");
            }


        }

        private void bttnUWeight_Click_1(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewCriminals.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridViewCriminals.CurrentRow;

                // Extract the criminal
                var selectedCriminal = selectedRow.Tag as Criminal;

                if (selectedCriminal == null)
                {
                    MessageBox.Show("Selected criminal information is not valid.");
                    return;
                }

                // Get the weight from the textbox
                string weightText = txtBoxUWeight.Text;

                // Validate the weight input
                if (string.IsNullOrWhiteSpace(weightText) || !decimal.TryParse(weightText, out decimal newWeight) || newWeight <= 0)
                {
                    MessageBox.Show("Please enter a valid weight.");
                    return;
                }

                MessageBox.Show("Weight information updated successfully.");
                UpdateCriminalWeight(selectedCriminal.Id, newWeight);

                // Update the weight directly in the DataGridView
                selectedRow.Cells["Weight"].Value = newWeight.ToString("C");  // Update the weight cell in the grid
            }
            else
            {
                MessageBox.Show("Please select a criminal to update.");
            }

        }

        private void bttnChangeCase_Click(object sender, EventArgs e)
        {
            var selectedCriminal = dataGridViewCriminals.CurrentRow.Tag as Criminal;
            if (selectedCriminal != null)
            {
                // Toggle the IsSolved status
                selectedCriminal.IsSolved = !selectedCriminal.IsSolved;

                // Update the database with this change
                UpdateCriminalStatusInDatabase(selectedCriminal);

                // Update the UI to reflect the new status
                if (selectedCriminal.IsSolved)
                {
                    dataGridViewCriminals.CurrentRow.Cells["Status"].Value = "Case Closed";
                    MessageBox.Show("The case is now closed.");
                }
                else
                {
                    dataGridViewCriminals.CurrentRow.Cells["Status"].Value = "Case Open";
                    MessageBox.Show("The case is now open.");
                }
            }
        }
        private void submitButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewCriminals.CurrentRow != null)
            {
                var selectedCriminal = dataGridViewCriminals.CurrentRow.Tag as Criminal;
                if (selectedCriminal != null)
                {

                    string ageText = txtAge.Text;
                    if (!string.IsNullOrWhiteSpace(ageText) && int.TryParse(ageText, out int newAge))
                    {
                        //Handling Age
                        UpdateCriminalAge(selectedCriminal.Id, newAge);
                        selectedCriminal.Age = newAge;
                        dataGridViewCriminals.CurrentRow.Cells["Age"].Value = newAge;
                    }


                    // Update Name
                    string criminal = txtBoxUName.Text;
                    UpdateCriminalName(selectedCriminal.Id, criminal);
                    selectedCriminal.Name = criminal;
                    dataGridViewCriminals.CurrentRow.Cells["Name"].Value = criminal;

                    // Update Height
                    string height = txtBoxUHeight.Text;
                    UpdateCriminalHeight(selectedCriminal.Id, height);
                    selectedCriminal.Height = height;
                    dataGridViewCriminals.CurrentRow.Cells["Height"].Value = height;

                    // Update Year
                    string yearText = txtBoxUYear.Text;
                    if (int.TryParse(yearText, out int year))
                    {
                        UpdateCriminalYear(selectedCriminal.Id, year);
                        selectedCriminal.Year = year;
                        dataGridViewCriminals.CurrentRow.Cells["Year"].Value = year;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid year.");
                    }

                    // Update Location
                    string location = txtBoxULocation.Text;
                    UpdateCriminalLocation(selectedCriminal.Id, location);
                    selectedCriminal.Location = location;
                    dataGridViewCriminals.CurrentRow.Cells["Location"].Value = location;

                    // Update Rental Price Per Day 
                    string weightText = txtBoxUWeight.Text;
                    if (decimal.TryParse(weightText, out decimal weight))

                    {
                        UpdateCriminalWeight(selectedCriminal.Id, weight);
                        selectedCriminal.Weight = weight;
                        dataGridViewCriminals.CurrentRow.Cells["Weight"].Value = weight.ToString("C");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid weight.");
                    }

                    // Handle Description Update
                    string descriptionInfo = descriptionInfoTextBox.Text;
                    if (string.IsNullOrWhiteSpace(descriptionInfo))
                    {
                        descriptionInfo = "None";
                    }

                    // Update description info in the database
                    UpdateCriminalDescription(selectedCriminal.Id, descriptionInfo);

                    // Update description info in the DataGridView
                    selectedCriminal.Description = descriptionInfo;
                    dataGridViewCriminals.CurrentRow.Cells["Description"].Value = descriptionInfo;


                    // Update the database
                    UpdateCriminalStatusInDatabase(selectedCriminal);



                    MessageBox.Show($"The criminal {selectedCriminal.Name} has been successfully updated.");
                }
            }
            else
            {
                MessageBox.Show("Please select a suspect to properly update the information.");
            }

        }
    }
}
