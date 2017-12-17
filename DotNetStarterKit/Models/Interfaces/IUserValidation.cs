using DotNetStarterKit.Models.EdmxModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarterKit.Models.Interfaces
{
    public interface IUserValidation
    {
        bool UserExists(string emailId);

        bool IsUserWithinAllowedRadius(int main, int cross);

        bool IsBooksPendingToReturn(long userId);

        bool IsUserSubscribed(User user);

        bool IsUserAllowedToCreate(User user);

        bool DeactivateUser(long userId, bool activeOrDeactiveStatus);
    }
}
