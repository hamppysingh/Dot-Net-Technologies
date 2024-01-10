using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductStoreWebApp.Models;

namespace ProductStoreWebApp.Services
{
    public interface IUserService
    {
        public List<User> GetUsers();

        public void AddUser(User user);
    }
}