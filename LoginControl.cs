using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_Sim
{
    class LoginControl
    {
        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public LoginControl(string use, string pass)
        {
            this.Username = use;
            this.Password = pass;
        }
        public static bool CheckUsername(string input)
        {
            string pattern = "^[a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckPassword(string input)
        {
            string pattern = "^[0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string uName = "admin";
        public string uPassWord = "12345";

        public bool Validate(string u, string p)
        {

            if (string.IsNullOrEmpty(u))
            {
                MessageBox.Show("Enter Username");
                return false;
            }
            else if (string.IsNullOrEmpty(p))
            {
                MessageBox.Show("Enter password");
                return false;
            }
            else if (CheckUsername(u) == false)
            {
                MessageBox.Show("Invalid charater detected: Enter letters only");
                return false;
            }
            else if (CheckPassword(p) == false)
            {
                MessageBox.Show("Invalid Character detected: Enter numbers only");
                return false;
            }
            else if (u != "admin")
            {
                MessageBox.Show("Incorrect Username");
                return false;
            }
            else if (p != "12345")
            {
                MessageBox.Show("Incorrect Password");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
