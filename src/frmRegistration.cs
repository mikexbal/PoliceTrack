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
    public partial class frmRegistration : Form
    {
        private DatabaseManagement database;
        public frmRegistration()
        {
            InitializeComponent();
            this.database = new DatabaseManagement();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string badgeID = tbBadgeID.Text;
            string firstname = tbFName.Text;
            string lastname = tbLName.Text;
            string phonenumber = tbPhone.Text;
            string email = tbEmail.Text;
            string rank = cbRank.SelectedItem.ToString();
            string birthday = dtpBirthday.Value.ToString("dd-MM-yyyy");
            string passowrd = tbPassword.Text;

            Employee employee = new Employee(badgeID, firstname, lastname, phonenumber, email, rank, birthday, passowrd);

            database.AddEmployee(employee);
            MessageBox.Show("Employee successfully added!");
            this.Close();
        }
    }
}
