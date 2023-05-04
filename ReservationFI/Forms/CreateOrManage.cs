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
    public partial class CreateOrManage : Form
    {
        public CreateOrManage()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnManageRes_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Show the new form
            var resManager = new ResManager();
            resManager.Closed += (s, args) => this.Close();
            resManager.Show();
        }

        private void btnCreateRes_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Show the new form
            var createRes = new Formular();
            createRes.Closed += (s, args) => this.Close();
            createRes.Show();
        }
    }
}
