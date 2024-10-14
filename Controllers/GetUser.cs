using Crud_MVC.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Crud_MVC.Models;
using Crud_MVC.Sevices;

namespace Crud_MVC.Controllers
{
    public class GetUser : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IApiService _apiService;

        public GetUser(IUserRepository userRepository, IApiService apiService)
        {
            _userRepository = userRepository;
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<ActionResult<UserModel>> GetUserData(int id)
        {
            UserModel userReceived = await _apiService.GET(id);
            return View(userReceived);
        }
    }
}
