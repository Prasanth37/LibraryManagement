using DotNetStarterKit.Models.EdmxModel;
using DotNetStarterKit.Models.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Web;
using System.Web.Http;

namespace DotNetStarterKit.Models
{
    public class UserRepository : IUserRepository
    {
        IUserValidation _userValidation;
        private LibraryManagementEntities libraryDbContext = new LibraryManagementEntities();

        public UserRepository()
        {
            _userValidation = new UserValidation();
        }

        public IEnumerable<User> GetUsers()
        {
            return libraryDbContext.Users;
        }

        public User GetUser(long id)
        {
            User user = libraryDbContext.Users.Find(id);
            return user;
        }

        public IEnumerable<User> GetLimitedUsers(int numberOfUsers)
        {
            var users = libraryDbContext.Users.Take(numberOfUsers);
            return users;
        }

        public void Create(User user)
        {
            if (_userValidation.IsUserAllowedToCreate(user))
            {
                libraryDbContext.Users.Add(user);
                try
                {
                    libraryDbContext.SaveChanges();
                }
                catch (Exception)
                {

                }
            }
        }

        public void UpdateUser(User user)
        {
            libraryDbContext.Entry(user).State = EntityState.Modified;

            try
            {
                libraryDbContext.SaveChanges();
            }
            catch (Exception)
            {

            }
        }

        public User DeleteUser(long userId)
        {
            User user = libraryDbContext.Users.Find(userId);
            if (user != null && !_userValidation.IsBooksPendingToReturn(userId))
            {
                libraryDbContext.Users.Remove(user);
                libraryDbContext.SaveChanges();
            }
            return user;
        }

        public void ActivateOrDeactivateUser(long userId, bool isActive)
        {
            User user = libraryDbContext.Users.Find(userId);
            if (user != null)
            {
                isActive = _userValidation.DeactivateUser(userId, isActive);
                user.IsActive = isActive;
                libraryDbContext.Entry(user).State = EntityState.Modified;
                libraryDbContext.SaveChanges();
            }
        }

        public bool UserExists(string emailId)
        {
            return _userValidation.UserExists(emailId);
        }

        public void InsertBulkUsers(string userJson)
        {
            var userObject = JsonConvert.DeserializeObject<IEnumerable<User>>(userJson);


        }
    }
}