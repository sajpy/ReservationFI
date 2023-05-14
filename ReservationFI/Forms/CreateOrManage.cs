﻿
namespace ReservationFI
{
    public partial class CreateOrManage : Form
    {
        private readonly IServiceProvider _services;

        public CreateOrManage(IServiceProvider services)
        {
            _services = services;
            InitializeComponent();
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
    }
}
