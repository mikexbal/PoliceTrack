using PoliceDatabaseProgam;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace PoliceDatabaseProgram.Models
{
    public class Inventory
    {
        private List<Criminal> criminals;
        private const string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Naeem\Downloads\OneDrive_2024-12-03\3309 Final Project\PoliceDatabaseProgam\PoliceDatabase.accdb;";

        public Inventory()
        {
            criminals = new List<Criminal>();
            LoadCriminalsFromDatabase();
        }

        // Method to add a criminal to the inventory
        public void AddCriminal(Criminal criminal)
        {
            criminals.Add(criminal);
            SaveCriminalToDatabase(criminal); // Save criminal to the database after adding
        }

        // Method to get all criminals in the inventory
        public List<Criminal> GetAllCriminals()
        {
            return criminals;
        }

        public void ClearInventory()
        {
            criminals.Clear();
            ClearSavedInventory(ConnectionString); // Clears the database table
        }

        public void ClearSavedInventory(string connectionString)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Criminals";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Method to get unsolved cases
        public List<Criminal> GetUnsolvedCases()
        {
            return criminals.FindAll(criminal => !criminal.IsSolved);
        }

        // Method to get solved cases
        public List<Criminal> GetSolvedCases()
        {
            return criminals.FindAll(criminal => criminal.IsSolved);
        }

        // Method to search criminals by category of crime
        public List<Criminal> SearchByCategory(string category)
        {
            return criminals.FindAll(criminal => criminal.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
        }

        // Method to get a criminal by name and height
        public Criminal GetCriminalByDetails(string name, string height)
        {
            return criminals.Find(criminal =>
                criminal.Name.Equals(name, StringComparison.OrdinalIgnoreCase) &&
                criminal.Height.Equals(height, StringComparison.OrdinalIgnoreCase));
        }

        // Method to save a criminal to the database
        private void SaveCriminalToDatabase(Criminal criminal)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string query = "INSERT INTO Criminals ([Category], [Name], [Year], [Age], [Height], [Weight], [IsSolved], [Description], [Location], [ImageURL]) " +
                               $"VALUES ('{criminal.Category ?? "Unspecified"}', '{criminal.Name ?? "Unknown"}', {criminal.Year}, " +
                               $"{criminal.Age}, '{criminal.Height ?? "Unknown"}', {criminal.Weight}, {criminal.IsSolved}, '{criminal.Description ?? ""}', '{criminal.Location ?? ""}', '{criminal.ImageUrl?? ""}')";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Method to load criminals from the database
        private void LoadCriminalsFromDatabase()
        {
            criminals.Clear();
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT Category, Name, Year, Age,Height, Weight, IsSolved, Description, Location, ImageURL FROM Criminals";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string category = reader["Category"]?.ToString() ?? "Unspecified";
                        string name = reader["Name"]?.ToString() ?? "Unknown";
                        string height = reader["Height"]?.ToString() ?? "Unknown";
                        int year = reader["Year"] != DBNull.Value ? Convert.ToInt32(reader["Year"]) : 1999;
                        int age = reader["Age"] != DBNull.Value ? Convert.ToInt32(reader["Age"]) : 0;
                        decimal weight = reader["Weight"] != DBNull.Value ? Convert.ToDecimal(reader["Weight"]) : 0m;
                        bool isSolved = reader["IsSolved"] != DBNull.Value && Convert.ToBoolean(reader["IsSolved"]);
                        string description = reader["Description"]?.ToString() ?? string.Empty;
                        string location = reader["Location"]?.ToString() ?? string.Empty;
                        string imageURL = reader["ImageURL"]?.ToString() ?? string.Empty;

                        criminals.Add(new Criminal(category, name, year, age, height, weight, isSolved, description, location, imageURL));
                    }
                   
                }
            }
        }
    }
}
