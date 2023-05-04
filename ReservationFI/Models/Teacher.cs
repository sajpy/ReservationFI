namespace ReservationFI.Models
{
    public class Teacher
    {
        // teacher is a user who has some courses and some reservations
        public int Id { get; set; }
        public User User { get; set; }
        public List<Course> Courses { get; set; }
        public List<Reservation> Reservations { get; set; }

    }
}