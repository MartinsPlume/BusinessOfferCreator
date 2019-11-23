using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfferCreation
{
    public partial class LoginPage : Form
    {
        OfferCreator offerCreator;
        public LoginPage()
        {
            InitializeComponent();
            DBConnect userCheck = new DBConnect();
            if (userCheck.checkUser()) 
            {
                MessageBox.Show("Admin added! Use Admin and pass to sign in!");
            };
        }

        private void buttonSignInClick(object sender, EventArgs e)
        {
            string user = textBoxUsername.Text.Trim();
            string pass = textBoxPassword.Text.Trim();
            try
            {
                DBConnect dbConnection = new DBConnect();
                if (dbConnection.SignIn(user, pass))
                {
                    Console.WriteLine("Logged in");
                    Console.WriteLine(dbConnection.isAdmin);
                    offerCreator = new OfferCreator(dbConnection.currentUser,dbConnection.isAdmin);
                    offerCreator.Show();
                }
                else
                {
                    MessageBox.Show("Log in failed!");
                }
            }
            catch (Exception es)
            {
                Console.WriteLine("Failed login --> "+ es);
            }
        }
    }
}
