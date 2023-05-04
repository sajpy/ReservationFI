using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using ReservationFI.Models;
using ReservationFI.Repositories.IRepository;
using System.Globalization;

namespace ReservationFI
{
    public partial class ResManager : Form
    {
        private readonly IServiceProvider _services;
        private readonly IReservationRepository _reservationRepository;
        public ResManager(IServiceProvider services)
        {
            _services = services;
            _reservationRepository = _services.GetRequiredService<IReservationRepository>();
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            CreateOrManage createOrManage = new(_services);

            this.Hide();
            createOrManage.Closed += (s, args) => this.Close();
            createOrManage.Show();
        }

        private void ResManager_Load(object sender, EventArgs e)
        {
            var reservations = _reservationRepository.GetAllReservationsWithRooms()
                .Select(r => new Reservation
                {
                    Id = r.Id,
                    RoomId = r.RoomId,
                    RoomName = r.RoomName,
                    StartDate = r.StartDate,
                    StartTime = r.StartTime,
                    EndTime = r.EndTime
                })
                .OrderBy(r => r.StartDate)
                .ThenBy(r => r.StartTime)
                .ToList();

            dgReservations.DataSource = reservations;

            // Hide the columns you don't want to show
            dgReservations.Columns["Id"].Visible = false;
            dgReservations.Columns["RoomId"].Visible = false;
            dgReservations.Columns["UserId"].Visible = false;

            //foreach (DataGridViewColumn col in dgReservations.Columns)
            //{
            //    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //}

            //dgReservations.Columns[1].ReadOnly = true;
            dgReservations.Columns[4].HeaderText = "ROOM";

            //dgReservations.Columns[2].ReadOnly = true;
            dgReservations.Columns[5].HeaderText = "DATE";


            //dgReservations.Columns[3].ReadOnly = true;
            dgReservations.Columns[6].HeaderText = "START";

            dgReservations.Columns[7].HeaderText = "END";
        }

        private void btnDeleteRes_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgReservations.SelectedRows)
            {
                Reservation res = (Reservation)row.DataBoundItem;

                _reservationRepository.Delete(res);
            }

            this.ResManager_Load(this, e);

        }
    }
}
