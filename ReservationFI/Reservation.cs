namespace ReservationFI
{
    public class Reservation
    {
        // reservation has a id, room in which the reservation is made, teacher who made the reservation, start date, start time and end time
        public int Id { get; set; }
        public Room Room { get; set; }
        //public Teacher Teacher { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        //public List<Student> Students { get; set; }

    }
}