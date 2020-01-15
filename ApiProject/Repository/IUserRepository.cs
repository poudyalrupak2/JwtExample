using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Models;

namespace Dating.API.Repositories
{
    public interface IUserRepository
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetUserWithProfiles(int userId);
        User GetProfile(int id);
        User Create(User user, string password);
        void Delete(int id);
        bool UserExists(int userId);
        bool Save();
    }
}