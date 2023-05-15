using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservationFI.Models
{
    public class Reservation
    {
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
    }
}