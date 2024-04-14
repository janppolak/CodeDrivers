using CodeDrivers.Models;

namespace CodeDriversMVC.Services.Interfaces
{
    public interface IRegistrationService : IRepository<User>
    {
        User GetByEmail(string email);
        void Remove(string email);
        bool IsEmailRegistered(string email);
    }
}
