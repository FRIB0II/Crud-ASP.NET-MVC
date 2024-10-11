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

        public IActionResult Index()
        {
            return View();
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
                TempData["Message"] = "Usuário não encontrado";
                return RedirectToAction("Index", "home");
            }
        }
    }
}
