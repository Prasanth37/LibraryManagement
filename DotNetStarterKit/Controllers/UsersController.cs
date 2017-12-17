using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DotNetStarterKit.Models;
using DotNetStarterKit.Models.EdmxModel;
using DotNetStarterKit.Models.Interfaces;

namespace DotNetStarterKit.Controllers
{
    public class UsersController : ApiController
    {
        private IUserRepository _userRepository;

        public UsersController()
        {
            _userRepository = new UserRepository();
        }

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: api/Users
        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public IEnumerable<User> GetLimitedUsers(int numberOfUsers)
        {
            return _userRepository.GetLimitedUsers(numberOfUsers);
        }

        // GET: api/Users/5
        [ResponseType(typeof(User))]
        public User GetUser(long userId)
        {
            return  _userRepository.GetUser(userId);
        }

        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser(User user)
        {
            try
            {
                _userRepository.UpdateUser(user);
            }
            catch (DbUpdateConcurrencyException)
            {

            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Users
        [ResponseType(typeof(User))]
        public IHttpActionResult PostUser(User user)
        {
            try
            {
                _userRepository.Create(user);
            }
            catch (DbUpdateException)
            {

            }

            return CreatedAtRoute("DefaultApi", new { id = user.UserId }, user);
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(User))]
        public IHttpActionResult DeleteUser(long id)
        {
            User user = _userRepository.DeleteUser(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        public bool UserExists(string emailId)
        {
            return _userRepository.UserExists(emailId);
        }

        public void InsertBulkUsers(string usersJson)
        {
            _userRepository.InsertBulkUsers(usersJson);
        }
    }
}