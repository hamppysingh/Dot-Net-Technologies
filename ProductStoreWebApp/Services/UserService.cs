using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductStoreWebApp.Models;
using ProductStoreWebApp.Repositories;

namespace ProductStoreWebApp.Services;
    public class UserService:IUserService
    {
        public List<User> GetUsers(){
            RepositoryManager mgr=new RepositoryManager();
            string fn=@"./users.json";
            List<User> user=mgr.DeSerializeUsers(fn);
            return user;
        }
        public void AddUser(User user){
            RepositoryManager mgr=new RepositoryManager();
            string fn=@"./users.json";
            List<User> newuserlist=mgr.DeSerializeUsers(fn);
            newuserlist.Add(user);
            mgr.SerializeUsers(newuserlist,fn);
        }
    }
