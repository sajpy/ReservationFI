using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservationFI.Models
{
    /// <summary>
    /// Class representing a Room, at this time, the capacity is not used.
    /// Meant for future upgrades.
    /// </summary>
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string RoomName { get; set; }
        public int RoomCapacity { get; set; }
    }
}