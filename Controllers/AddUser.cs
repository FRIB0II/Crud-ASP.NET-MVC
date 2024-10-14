using Crud_MVC.Models;
using Crud_MVC.Repository.Interfaces;
using Crud_MVC.Sevices;
using Microsoft.AspNetCore.Mvc;

namespace Crud_MVC.Controllers
{
    public class AddUser : Controller
    {

        private readonly IUserRepository _userRepository;
        private readonly IApiService _apiService;
            
        public AddUser(IUserRepository userRepository, IApiService apiService)
        {
            _userRepository = userRepository;
            _apiService = apiService;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> NewUser(UserModel user)
        {
            await _apiService.POST(user);
            return RedirectToAction("Index", "Home");
        }
    }
}
