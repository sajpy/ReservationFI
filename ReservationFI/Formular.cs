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
    public partial class Formular : Form
    {

        private readonly IRoomRepository _roomRepository;
        public Formular()
        {
            InitializeComponent();
            _roomRepository = new RoomRepository(new ReservationDbContext());
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            CreateOrManage createOrManage = new();

            this.Hide();
            createOrManage.Closed += (s, args) => this.Close();
            createOrManage.Show();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Formular_Load(object sender, EventArgs e)
        {
            cbRooms.DataSource = _roomRepository.GetAllRooms().Select(x => x.RoomName).ToList();
            dpDate.MinDate= DateTime.Now;
        }
    }
}
