using ReservationFI.Models;


namespace ReservationFI.Repositories.IRepository
{
    /// <summary>
    /// Interface for the UserRepository, which is used to access the database.
    /// </summary>
    public interface IUserRepository
    {
        void Add(User user);
        User? GetByFirstAndLastName(string firstName, string lastName);
        User? Login(string username, string password);
        User? GetCurrentUser();
    }
}
