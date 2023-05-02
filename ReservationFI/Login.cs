using Microsoft.Win32;
using ReservationFI.IRepository;
using ReservationFI.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationFI
{
    public partial class Login : Form
    {
        private readonly UserRepository _userRepository;
        // i need to inject the user repository here

        public Login()
        {
            InitializeComponent();
            _userRepository = new UserRepository(new ReservationDbContext());
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // check if lblUsername and lblPassword are not empty
            // if they are empty, show a message box to the user
            // else, check if the username and password exist in the database
            // if they exist, show the main form
            // else, show a message box to the user
            
            tbError.Visible = true;

            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                tbError.Text = "Please enter your username and password";
            }
            else
            {
                if(_userRepository.Login(tbUsername.Text, tbPassword.Text) == null)
                {
                    tbError.Text = "Username or password is incorrect";
                }
                else
                {
                    tbError.Visible = false;

                    // Hide the current form
                    this.Hide();
                    // Show the new form
                    var createOrManage = new CreateOrManage();
                    createOrManage.Closed += (s, args) => this.Close();
                    createOrManage.Show();
                }

            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {

            // Hide the current form
            this.Hide();

            // Show the new form
            var registerForm = new Register();
            registerForm.Closed += (s, args) => this.Close();
            registerForm.Show();

        }
    }
}
