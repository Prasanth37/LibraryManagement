using DotNetStarterKit.Models.EdmxModel;
using DotNetStarterKit.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetStarterKit.Models
{
    public class UserValidation : IUserValidation
    {
        LibraryManagementEntities libraryDbContext = new LibraryManagementEntities();

        public bool UserExists(string emailId)
        {
            return libraryDbContext.Users.Count(e => e.EmailId == emailId) > 0;
        }

        public bool IsUserWithinAllowedRadius(int main, int cross)
        {
            try
            {
                int allowedRadius = libraryDbContext.MemberShipRules.Select(x => x.AllowedRadius).FirstOrDefault();

                if (Math.Sqrt((main * main) + (cross * cross)) <= allowedRadius)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return false;
        }

        public bool IsBooksPendingToReturn(long userId)
        {
            return libraryDbContext.BookIssueHistories.Where(x => userId == x.UserId && x.IsReturned == true).Select(x => x).Count() <= 0;
        }

        public bool IsUserSubscribed(User user)
        {
            return user.SubscriptionId > 0;
        }

        public bool IsValidEmail(string emailId)
        {
            return !string.IsNullOrEmpty(emailId);
        }

        public bool IsUserAllowedToCreate(User user)
        {
            return (IsValidEmail(user.EmailId) && !UserExists(user.EmailId) && IsUserWithinAllowedRadius(user.Main, user.Cross) && IsUserSubscribed(user));
        }

        public bool DeactivateUser(long userId, bool activeOrDeactiveStatus)
        {
            return activeOrDeactiveStatus ? activeOrDeactiveStatus : this.IsBooksPendingToReturn(userId);
        }
    }
}