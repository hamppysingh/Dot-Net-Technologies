using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductStoreWebApp.Models;
using Microsoft.Extensions.Logging;
using System.Collections;
using ProductStoreWebApp.Repositories;
using ProductStoreWebApp.Services;

namespace ProductStoreWebApp.Controllers
{
    
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult SignIn(){
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(IFormCollection form){
            var password=form["psw"].ToString();
            var name=form["uname"].ToString();
            RepositoryManager mgr=new RepositoryManager();
            string fn=@"./users.json";
            List<User> user=mgr.DeSerializeUsers(fn);
            User checkuser=new User(name,password);
            if(user.Contains(checkuser)){
                TempData["user"]=name;
                return RedirectToAction("Hello","Dashboard",null);
            }
            return View();
        }
        public IActionResult Register(){
            return View();
        }

        [HttpPost]
        public IActionResult Register(IFormCollection form)
        {
            var password=form["Password"].ToString();
            var name=form["Name"].ToString();
            User insertuser=new User(name,password);
            UserService us=new UserService();
            us.AddUser(insertuser);
            Console.WriteLine(password+" "+name);
            return RedirectToAction("SignIn","Auth",null);
        }
        public IActionResult Error()
        {
            return View("Error!");
        }

    }
}