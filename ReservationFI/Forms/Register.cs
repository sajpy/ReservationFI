using Microsoft.Extensions.DependencyInjection;
using ReservationFI.Models;
using ReservationFI.Repositories.IRepository;

namespace ReservationFI
{
    public partial class Register : Form
    {
        private readonly IServiceProvider _services;
        private readonly IUserRepository _userRepository;

        public Register(IServiceProvider services)
        {
            _services = services;
            _userRepository = services.GetRequiredService<IUserRepository>();
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Login loginForm = new(_services);

            this.Hide();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();

        }

        /// <summary>
        /// Method for registering a new user.
        /// Validates the input and checks if the user already exists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {

            tbError.Visible = true;
            tbError.ForeColor = Color.Red;

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
                        User user = new()
                        {
                            FirstName = tbFirstName.Text,
                            LastName = tbLastName.Text,
                            UserName = tbUsername.Text,
                            UserPassword = tbPassword.Text,
                            IsAdmin = false
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
