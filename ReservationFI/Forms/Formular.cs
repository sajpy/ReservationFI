using ReservationFI.IRepository;
using ReservationFI.Models;
using ReservationFI.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using static Azure.Core.HttpHeader;


namespace ReservationFI
{
    public partial class Formular : Form
    {

        private readonly IRoomRepository _roomRepository;
        private readonly IReservationRepository _reservationRepository;
        private bool _isDateChanged = false;
        

        public Formular()
        {
            InitializeComponent();
            _roomRepository = new RoomRepository(new ReservationDbContext());
            _reservationRepository = new ReservationRepository(new ReservationDbContext());
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

            cbEndingAt.Enabled = false;

            dpDate.CustomFormat = " ";
            dpDate.Format = DateTimePickerFormat.Custom;
        }

        private void dpDate_ValueChanged(object sender, EventArgs e)
        {
            dpDate.CustomFormat = "dd/MM/yyyy";
            dpDate.ValueChanged -= dpDate_ValueChanged;
            cbStartingAt.Enabled = false;

            cbStartingAt.Items.Clear();
            cbEndingAt.Items.Clear();

            if (_isDateChanged)
            {
                tbError.Visible = true;

                List<string> freeTimes = _reservationRepository.GetFreeTimes(dpDate.Text, cbRooms.Text);

                foreach (var item in freeTimes)
                {
                    cbStartingAt.Items.Add(item);
                    cbEndingAt.Items.Add(item);
                }

                cbStartingAt.Enabled = true;
            }
        }

        private void dpDate_CloseUp(object sender, EventArgs e)
        {
            dpDate.ValueChanged += dpDate_ValueChanged;
            _isDateChanged = true;
            dpDate_ValueChanged(sender, e);
        }

        private void btnCreateRes_Click(object sender, EventArgs e)
        {
            tbError.ForeColor = Color.Red;
            
            if (cbRooms.SelectedItem == null || cbStartingAt.SelectedItem == null || cbEndingAt.SelectedItem == null)
            {
                tbError.Visible = true;
                tbError.Text = "Please fill all the fields!";
            }

            else
            {
                tbError.Visible = true;

                int roomId = _roomRepository.GetIdByRoomName(cbRooms.SelectedItem.ToString());

                Reservation reservation = new()
                {
                    StartDate = dpDate.Text,
                    StartTime = cbStartingAt.Text,
                    EndTime = cbEndingAt.Text,
                    RoomId = roomId,
                    UserId = 3,
                };

                _reservationRepository.Add(reservation);
                tbError.ForeColor = Color.Green;

                tbError.Text = dpDate.Text;
            }
        }

        private void cbStartingAt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Array values = Enum.GetValues(typeof(Times.TimesEnum));

            //foreach (Times.TimesEnum item in values)
            //{
            //    cbEndingAt.Items.Add(item.GetDescription());
            //}


            //cbEndingAt.SelectedIndex = cbStartingAt.SelectedIndex + 1;

        }
    }
}
