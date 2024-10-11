using Crud_MVC.Models;
using Crud_MVC.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Crud_MVC.Controllers
{
    public class AddUser : Controller
    {

        private readonly IUserRepository _userRepository;
            
        public AddUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewUser(UserModel user)
        {
            _userRepository.AddUser(user);
            return RedirectToAction("Index", "Home");
        }
    }
}
