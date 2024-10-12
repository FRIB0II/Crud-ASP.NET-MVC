using Crud_MVC.Models;
using Crud_MVC.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Crud_MVC.Controllers
{
    public class DeleteUser : Controller
    {
        private readonly IUserRepository _userRepository;

        public DeleteUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index(int id)
        {   
            UserModel userSearched = _userRepository.GetUser(id);
            return View(userSearched);
        }

        public IActionResult RemoveUser(int id)
        {
            bool userDeleted = _userRepository.DeleteUser(id);

            if (userDeleted)
            {
                return RedirectToAction("Index", "home");
            }
            else
            {
                return RedirectToAction("Index", "DeleteUser");
            }
        }
    }
}
