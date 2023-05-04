using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ReservationFI.Models;
using ReservationFI.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationFI
{
    public partial class Register : Form
    {
        private readonly UserRepository _userRepository;

        public Register()
        {
            InitializeComponent();

            // Create an instance of UserRepository and store it as a private field
            _userRepository = new UserRepository(new ReservationDbContext());
        }



        private void lblBack_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();

            this.Hide();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // TODO: Add validation, add success message, redirect to login after successful registration

            tbError.Visible = true;
            tbError.ForeColor= Color.Red;

            if (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbLastName.Text) || string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tbPasswordConfirm.Text))
            {
                tbError.Text = "Please fill in all the fields";
            }
            else
            {
                if (tbPassword.Text != tbPasswordConfirm.Text)
                {
                    tbError.Text = "Passwords do not match";
                }
                else
                {

                    if (_userRepository.GetByFirstAndLastName(tbFirstName.Text, tbLastName.Text) != null)
                    {
                        tbError.Text = "User with this name already exists";
                    }

                    else
                    {

                        //create a user

                        User user = new()
                        {
                            FirstName = tbFirstName.Text,
                            LastName = tbLastName.Text,
                            Username = tbUsername.Text,
                            UserPassword = tbPassword.Text,
                            //IsTeacher = chbTeacher.Checked,
                            //IsStudent = chbStudent.Checked
                        };

                        _userRepository.Add(user);

                        tbError.ForeColor = Color.Green;
                        tbError.Text = "Account created successfully";
                    }
                }
            }

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
