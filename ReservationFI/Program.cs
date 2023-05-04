using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReservationFI.Repositories.IRepository;
using ReservationFI.Repositories.Repository;

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
            var services = new ServiceCollection();
            services.AddDbContext<ReservationDbContext>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IRoomRepository, RoomRepository>();
            services.AddSingleton<IReservationRepository, ReservationRepository>();

            var login = new Login(services.BuildServiceProvider());

            Application.Run(login);

        }
    }
}