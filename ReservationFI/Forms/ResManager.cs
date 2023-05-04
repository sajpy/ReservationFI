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
    public partial class ResManager : Form
    {
        public ResManager()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            CreateOrManage createOrManage = new();

            this.Hide();
            createOrManage.Closed += (s, args) => this.Close();
            createOrManage.Show();
        }
    }
}
