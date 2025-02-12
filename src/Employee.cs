using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//Mike
namespace PoliceDatabaseProgam
{
   
    internal class Employee
    {
        private string badgeID;
        private string firstname;
        private string lastname;
        private string phonenumber;
        private string email;
        private string rank;
        private string birthday;
        private string passowrd;

        public Employee(string badgeID, string firstname, string lastname, string phonenumber, string email, string rank, string birthday, string passowrd)
        {
            this.badgeID = badgeID;
            this.firstname = firstname;
            this.lastname = lastname;
            this.phonenumber = phonenumber;
            this.email = email;
            this.rank = rank;
            this.birthday = birthday;
            this.passowrd = passowrd;
        }

        public string BadgeID { get { return badgeID; } }
        public string Firstname { get { return firstname; } }
        public string Lastname { get { return lastname; } } 
        public string Phonenumber { get { return phonenumber; } }
        public string Email { get { return email; } }
        public string Rank { get { return rank; } }
        public string Birthday { get { return birthday; } } 
        public string Passowrd { get { return passowrd; } }
    }
}
