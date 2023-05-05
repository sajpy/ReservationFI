using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ReservationFI.Models
{
    public class Reservation
    {
        // reservation has a id, room in which the reservation is made, teacher who made the reservation, start date, start time and end time
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Room")]
        public int RoomId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [NotMapped]
        public string RoomName { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        [NotMapped]
        public string UserFirstName { get; set; }
        [NotMapped]
        public string UserLastName { get; set; }

        //public List<Student> Students { get; set; }

    }
}