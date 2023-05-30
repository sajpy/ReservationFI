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

            var serviceProvider = services.BuildServiceProvider();

            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ReservationDbContext>();
                dbContext.Database.EnsureCreated(); // Ensure the database is created

                // Apply any pending migrations
                dbContext.Database.Migrate();

                var seeder = new Seeder(dbContext);
                seeder.SeedData();
            }

            var login = new Login(services.BuildServiceProvider());
            Application.Run(login);

        }
    }
}