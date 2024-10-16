﻿using Crud_MVC.Models;
using Crud_MVC.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Crud_MVC.Controllers
{
    public class UpdateUser : Controller
    {
        private readonly IUserRepository _userRespository;

        public UpdateUser(IUserRepository userRespository)
        {
            _userRespository = userRespository;
        }

        public IActionResult Index(int id)
        {
            UserModel searchedUser = _userRespository.GetUser(id);
            return View(searchedUser);
        }

        [HttpPost]
        public IActionResult Index(UserModel user)
        {
            _userRespository.UpdateUser(user);
            return RedirectToAction("index", "home");
        }
    }
}
