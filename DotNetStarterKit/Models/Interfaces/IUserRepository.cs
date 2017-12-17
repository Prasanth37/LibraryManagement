//using DotNetStarterKit.Domain;
using DotNetStarterKit.Models.EdmxModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarterKit.Models.Interfaces
{
    public interface IUserRepository
    {
        void Create(User user);
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetLimitedUsers(int numberOfUsers);
        User GetUser(long userId);
        void UpdateUser(User user);
        User DeleteUser(long UserId);
        void ActivateOrDeactivateUser(long userId, bool isActive);
        bool UserExists(string emailId);
        void InsertBulkUsers(string userJson);
    }
}
