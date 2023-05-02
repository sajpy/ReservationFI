using Microsoft.EntityFrameworkCore;

namespace ReservationFI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var dbContext = new ReservationDbContext();
            Application.Run(new Login());

            dbContext.Database.GetDbConnection().Close();
        }
    }
}