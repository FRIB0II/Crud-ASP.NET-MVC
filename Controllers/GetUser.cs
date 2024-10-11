using Crud_MVC.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Crud_MVC.Models;

namespace Crud_MVC.Controllers
{
    public class GetUser : Controller
    {
        private readonly IUserRepository _userRepository;

        public GetUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult GetUserData(int id)
        {
            UserModel userReceived = _userRepository.GetUser(id);
            return View(userReceived);
        }
    }
}
