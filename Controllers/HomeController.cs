using Crud_MVC.Models;
using Crud_MVC.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Crud_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;

        public HomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            List<UserModel> listOfUsers = _userRepository.GetAllUsers();
            return View(listOfUsers);
        }
    }
}
