using Microsoft.EntityFrameworkCore;
using ReservationFI.Models;

namespace ReservationFI
{
    /// <summary>
    /// Class representing the database context for the ReservationFI application.
    /// </summary>
    public class ReservationDbContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=ReservationFI;Trusted_Connection=True;");
        }
    }
}
