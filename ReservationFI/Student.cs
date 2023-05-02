namespace ReservationFI
{
    public class Student
    {
        // student is a user who has some courses and some reservations that he didnt make, but was added to by a teacher
        public int Id { get; set; }
        public User User { get; set; }
        public List<Course> Courses { get; set; }
        public List<Reservation> Reservations { get; set; } 
    }
}