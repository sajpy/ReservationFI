using Microsoft.Extensions.DependencyInjection;
using ReservationFI.Models;
using ReservationFI.Repositories.IRepository;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace ReservationFI
{
    public partial class ResManager : Form
    {
        private readonly IServiceProvider _services;
        private readonly IReservationRepository _reservationRepository;
        private readonly IUserRepository _userRepository;

        private readonly string[] _paths = { "..", "..", "..", "Reservations.json" };
        private readonly string _filePath;

        public ResManager(IServiceProvider services)
        {
            _services = services;
            _reservationRepository = _services.GetRequiredService<IReservationRepository>();
            _userRepository = _services.GetRequiredService<IUserRepository>();
            _filePath = Path.Combine(_paths);

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

        /// <summary>
        /// Method for loading the reservations from the database. 
        /// Also checks if the user is an admin or not, and displays the reservations accordingly.
        /// Reservations from the past are displayed with different colors.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResManager_Load(object sender, EventArgs e)
        {
            User? currentUser = _userRepository.GetCurrentUser();

            List<Reservation> reservations;

            if (currentUser!.IsAdmin)
            {
                reservations = _reservationRepository.GetAllReservations();
            }
            else
            {
                reservations = _reservationRepository.GetAllReservationsForUser(currentUser);
            }

            dgReservations.DataSource = reservations;

            dgReservations.Columns["Id"].Visible = false;
            dgReservations.Columns["RoomId"].Visible = false;
            dgReservations.Columns["UserId"].Visible = false;

            dgReservations.Columns[0].Visible = false;

            dgReservations.Columns[4].HeaderText = "ROOM";

            dgReservations.Columns[5].HeaderText = "DATE";

            dgReservations.Columns[6].HeaderText = "START";

            dgReservations.Columns[7].HeaderText = "END";

            dgReservations.Columns[8].HeaderText = "USER";
            dgReservations.Columns[9].HeaderText = "";

            foreach (DataGridViewRow row in dgReservations.Rows)
            {
                Reservation res = (Reservation)row.DataBoundItem;

                DateTime resDate = DateTime.ParseExact(res.StartDate, "dd/MM/yyyy", null);
                if (resDate < DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        /// <summary>
        /// Method for deleting the selected reservation/s from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteRes_Click(object sender, EventArgs e)
        {
            tbError.Visible = true;
            int selectedRowCount = dgReservations.SelectedRows.Count;
            foreach (DataGridViewRow row in dgReservations.SelectedRows)
            {
                Reservation res = (Reservation)row.DataBoundItem;
                _reservationRepository.Delete(res);
            }

            tbError.ForeColor = Color.Green;
            tbError.Text = "Deleted " + selectedRowCount + " reservation/s";

            this.ResManager_Load(this, e);
        }

        /// <summary>
        /// Method for exporting the reservations to a JSON file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnExport_Click(object sender, EventArgs e)
        {
            tbError.Visible = true;

            var reservations = (List<Reservation>)dgReservations.DataSource;

            var options1 = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };

            await using FileStream createStream = File.Create(_filePath);

            await JsonSerializer.SerializeAsync(createStream, reservations, options1);

            tbError.ForeColor = Color.Green;
            tbError.Text = "Exported!";
        }
    }
}
