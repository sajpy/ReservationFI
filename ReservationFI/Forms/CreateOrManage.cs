using Microsoft.Extensions.DependencyInjection;
using ReservationFI.Repositories.IRepository;

namespace ReservationFI
{
    public partial class CreateOrManage : Form
    {
        private readonly IServiceProvider _services;
        private readonly IUserRepository _userRepository;

        public CreateOrManage(IServiceProvider services)
        {
            _services = services;
            _userRepository = services.GetRequiredService<IUserRepository>();
            InitializeComponent();
            tbGreetings.Visible = true;
            tbGreetings.Text = $"Welcome {_userRepository.GetCurrentUser().FirstName} {_userRepository.GetCurrentUser().LastName}";
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnManageRes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var resManager = new ResManager(_services);
            resManager.Closed += (s, args) => this.Close();
            resManager.Show();
        }

        private void btnCreateRes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form createRes = new Formular(_services);
            createRes.Closed += (s, args) => this.Close();
            createRes.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Login(_services);
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}
