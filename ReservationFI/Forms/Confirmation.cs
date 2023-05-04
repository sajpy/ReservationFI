using Microsoft.Extensions.DependencyInjection;
using ReservationFI.Models;
using ReservationFI.Repositories.IRepository;


namespace ReservationFI
{
    public partial class Confirmation : Form
    {
        private readonly IServiceProvider _services;
        private readonly Reservation _reservation;
        private readonly IReservationRepository _reservationRepository;
        public Confirmation(IServiceProvider services, Reservation reservation)
        {
            _services = services;
            _reservation = reservation;
            _reservationRepository = _services.GetRequiredService<IReservationRepository>();
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            lblRoom.Text = _reservation.RoomName;
            lblDate.Text = _reservation.StartDate;
            lblStartingAt.Text = _reservation.StartTime;
            lblEndingAt.Text = _reservation.EndTime;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmRes_Click(object sender, EventArgs e)
        {
            _reservationRepository.Add(_reservation);

            btnConfirmRes.Text = "Reservation confirmed!";
            btnConfirmRes.BackColor = Color.Green;
            btnConfirmRes.Enabled = false;


            //Close();
        }
    }
}
