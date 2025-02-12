using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceDatabaseProgam
{
    internal class DatabaseManagement
    {
        private string strConnection;
        private string queryString;
        //Establish connection to database
        //Add Suspects & Employees to Database
        //Remove suspects and employees from database
        //Modify items in database

        public DatabaseManagement()
        {
            strConnection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Naeem\Downloads\OneDrive_2024-12-03\3309 Final Project\PoliceDatabaseProgam\PoliceDatabase.accdb;";

        }

        internal void AddEmployee(Employee employee)
        {
            OleDbConnection connection = new OleDbConnection(strConnection);

            queryString = $"INSERT INTO Employees ([BadgeID], [FName], [LName], [PhoneNumber], [Email], [EmployeeRank], [Birthdate], [Password])" +
                $"VALUES ('{employee.BadgeID}', '{employee.Firstname}', '{employee.Lastname}', " +
                $"'{employee.Phonenumber}', '{employee.Email}', '{employee.Rank}', '{employee.Birthday}', '{employee.Passowrd}') ";

            OleDbCommand command = new OleDbCommand(queryString, connection);
            connection.Open();
            Console.WriteLine(queryString);
            command.ExecuteNonQuery();
        
            connection.Close();
        }

        internal bool PasswordValidation(string badgeID, string enteredPassword)
        {
            OleDbConnection connection = new OleDbConnection(strConnection);
            queryString = $"SELECT Password FROM Employees WHERE BadgeID = '{badgeID}'";
            OleDbCommand command = new OleDbCommand(queryString, connection);
            connection.Open();

            try
            {
                object dbpassword = command.ExecuteScalar();

                if (dbpassword == null || dbpassword == DBNull.Value)
                {
                    return false;
                }

                string userPassword = dbpassword.ToString();


                if (enteredPassword == userPassword)
                {
                    return true;
                }
            }
            catch (NullReferenceException ex)
            {
                return false; // or handle the error as needed
            }


            connection.Close();


            return false;
   
        }
        
    }
}
