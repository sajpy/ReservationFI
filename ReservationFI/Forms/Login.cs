using Microsoft.Extensions.DependencyInjection;
using ReservationFI.Models;
using ReservationFI.Repositories.IRepository;

namespace ReservationFI
{
    public partial class Login : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IServiceProvider _services;

        public Login(IServiceProvider services)
        {
            _services = services;
            _userRepository = services.GetRequiredService<IUserRepository>();
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tbError.Visible = true;

            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                tbError.Text = "Please enter your username and password";
            }
            else
            {
                User? user = _userRepository.Login(tbUsername.Text, tbPassword.Text);

                if (user == null)
                {
                    tbError.Text = "Username or password is incorrect";
                }
                else
                {
                    tbError.Visible = false;

                    this.Hide();
                    Form createOrManage = new CreateOrManage(_services);
                    createOrManage.Closed += (s, args) => this.Close();
                    createOrManage.Show();
                }
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new Register(_services);
            registerForm.Closed += (s, args) => this.Close();
            registerForm.Show();
        }
    }
}
