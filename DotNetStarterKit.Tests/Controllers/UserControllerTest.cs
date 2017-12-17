using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetStarterKit.Controllers;
using DotNetStarterKit.Models.EdmxModel;
using System.Web.Http.Results;
using System.Linq;

namespace DotNetStarterKit.Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        [TestMethod]
        public void PostUser_AddValidUser_True()
        {
            UsersController usersController = new UsersController();

            User user = new User();
            user.FirstName = "John";
            user.LastName = "Smith";
            user.EmailId = "John.smith@gmail.com";
            user.IsActive = true;
            user.Mobile = 9994875612;
            user.SubscriptionId = 1;
            user.Main = 3;
            user.Cross = 4;

            usersController.PostUser(user);
            Assert.AreEqual(usersController.UserExists(user.EmailId), true);
        }

        [TestMethod]
        public void PostUser_AddInvalidUser_False()
        {
            UsersController usersController = new UsersController();

            User user = new User();
            user.FirstName = "John";
            user.LastName = "Smith";
            user.EmailId = "John.s2@gmail.com";
            user.IsActive = true;
            user.Mobile = 9994875612;
            user.SubscriptionId = 1;
            user.Main = 8;
            user.Cross = 6;

            usersController.PostUser(user);
            Assert.AreEqual(usersController.UserExists(user.EmailId), false);
        }

        [TestMethod]
        public void GetUser_ReadAvailableUserById_True()
        {
            UsersController usersController = new UsersController();
            int userID = 1;
            var user = usersController.GetUser(userID);
            Assert.AreEqual(user.UserId, userID);
        }

        [TestMethod]
        public void PutUser_UpdateMobileNumber_True()
        {
            UsersController usersController = new UsersController();
            User user = new User();
            user.UserId = 3;
            user.FirstName = "John";
            user.LastName = "Smith";
            user.EmailId = "John.s@gmail.com";
            user.IsActive = true;
            user.Mobile = 8056483053;
            user.SubscriptionId = 1;
            user.Main = 8;
            user.Cross = 6;
            usersController.PutUser(user);
            var updatedUser = usersController.GetUser(user.UserId);
            Assert.AreEqual(updatedUser.Mobile, user.Mobile);
        }

        [TestMethod]
        public void DeleteUser_DeleteEligibleUser_True()
        {
            UsersController usersController = new UsersController();

            int userId = 3;
            usersController.DeleteUser(userId);
            var user = usersController.GetUser(userId);
            Assert.AreEqual(user, null);
        }

        [TestMethod]
        public void DeleteUser_DeleteNonEligibleUser_False()
        {
            UsersController usersController = new UsersController();

            int userId = 5;
            usersController.DeleteUser(userId);
            var user = usersController.GetUser(userId);
            Assert.AreNotEqual(user, null);
        }


        [TestMethod]
        public void GetLimitedUsers_GetTwoRecords_True()
        {
            UsersController usersController = new UsersController();
            int numberOFUsers = 2;
            var users = usersController.GetLimitedUsers(numberOFUsers);
            var users1 = usersController.GetUsers();
            //((IQueryable) users1).l
            
        }


        public void InsertBulkUser_True()
        {
            UsersController usersController = new UsersController();
            var userJson = "{{ 'UserId':1,'FirstName':'John','LastName':'mith','EmailId':'John.s@gmail.com','Mobile':9994875612,'Main':3,'Cross':4,'SubscriptionId':1,'IsActive':true}, { 'UserId':1,'FirstName':'Prasanth','LastName':'mith','EmailId':'Prasanth.smith@gmail.com','Mobile':9994875612,'Main':3,'Cross':4,'SubscriptionId':1,'IsActive':true}}";
            usersController.InsertBulkUsers(userJson);
        }
    }
}
