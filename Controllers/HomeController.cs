using Crud_MVC.Models;
using Crud_MVC.Repository.Interfaces;
using Crud_MVC.Sevices;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Crud_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IApiService _apiService;

        public HomeController(IUserRepository userRepository, IApiService apiService)
        {
            _userRepository = userRepository;
            _apiService = apiService;
        }

        public async Task<ActionResult<List<UserModel>>> Index()
        {
            List<UserModel> listOfUsers =  await _apiService.GETALL();
            return View(listOfUsers);
        }
    }
}
