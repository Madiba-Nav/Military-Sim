using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_Sim
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string useEnt = txtUserName.Text;
            string passEnt = txtPassword.Text;
            LoginControl myLogIn = new LoginControl(useEnt, passEnt);

            if (myLogIn.Validate(useEnt, passEnt) == true)
            {
                MessageBox.Show("Login Successful");
                Simulation mySim = new Simulation();
                mySim.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login not Successful");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
