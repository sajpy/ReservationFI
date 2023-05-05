using Microsoft.Extensions.DependencyInjection;
using ReservationFI.Models;
using ReservationFI.Repositories.IRepository;
using System.Data;

namespace ReservationFI
{
    public partial class Formular : Form
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IReservationRepository _reservationRepository;
        private readonly IUserRepository _userRepository;
        private bool _isDateChanged = false;
        private readonly IServiceProvider _services;

        public Formular(IServiceProvider services)
        {
            _services = services;
            
            _reservationRepository = _services.GetRequiredService<IReservationRepository>();
            _userRepository = _services.GetRequiredService<IUserRepository>();
            _roomRepository = _services.GetRequiredService<IRoomRepository>();

            InitializeComponent();

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Form createOrManage = new CreateOrManage(_services);

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
            dpDate.MinDate= DateTime.Now;

            cbStartingAt.Enabled = true;
            cbEndingAt.Enabled = false;

            dpDate.Format = DateTimePickerFormat.Custom;
            dpDate.CustomFormat = "dd/MM/yyyy";

            cbRooms.DataSource = _roomRepository.GetAllRooms().Select(x => x.RoomName).ToList();
        }

        private void dpDate_ValueChanged(object sender, EventArgs e)
        {
            dpDate.ValueChanged -= dpDate_ValueChanged;

            cbStartingAt.Items.Clear();
            cbEndingAt.Items.Clear();

            if (_isDateChanged)
            {
                UpdatingCheckboxes();
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
                tbError.ForeColor = Color.Red;
                tbError.Text = "Please fill all the fields!";
            }

            else
            {
                tbError.Visible = true;

                int roomId = _roomRepository.GetIdByRoomName(cbRooms.SelectedItem.ToString());
                User user = _userRepository.GetCurrentUser();

                Reservation reservation = new()
                {
                    StartDate = dpDate.Text,
                    StartTime = cbStartingAt.Text,
                    EndTime = cbEndingAt.Text,
                    RoomId = roomId,
                    UserId = user.Id,
                    RoomName = cbRooms.Text,
                    UserFirstName = user.FirstName,
                    UserLastName = user.LastName
                };

                var confirmation = new Confirmation(_services, reservation);
                this.SuspendLayout();
                confirmation.ShowDialog(this);

                UpdatingCheckboxes();
            }
        }

        private void cbStartingAt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEndingAt.Items.Clear();

            Array values = Enum.GetValues(typeof(Times.TimesEnum));

            List<string> allTimes = new();
            foreach (Times.TimesEnum item in values)
            {
                allTimes.Add(item.GetDescription());
            }

            cbEndingAt.Items.Add(allTimes[allTimes.IndexOf((string)cbStartingAt.SelectedItem) + 1]);
            cbEndingAt.SelectedIndex = 0;

            cbEndingAt.Enabled = false;
        }

        private void UpdatingCheckboxes()
        {
            cbStartingAt.Items.Clear();
            cbEndingAt.Items.Clear();
            tbError.Visible = true;

            List<string> freeTimes = _reservationRepository.GetFreeTimes(dpDate.Text, cbRooms.Text);

            foreach (var item in freeTimes)
            {
                cbStartingAt.Items.Add(item);
            }

            cbStartingAt.Items.RemoveAt(cbStartingAt.Items.Count - 1);

            if (cbStartingAt.Items.Count == 0)
            {
                cbStartingAt.Enabled = false;
                tbError.ForeColor = Color.Red;
                tbError.Text = "There are no free reservations for this date!";
            }
            else
            {
                tbError.Clear();
                cbStartingAt.Enabled = true;
            }
        }

        private void cbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatingCheckboxes();
        }
    }
}
