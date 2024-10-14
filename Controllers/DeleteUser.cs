using Crud_MVC.Models;
using Crud_MVC.Repository.Interfaces;
using Crud_MVC.Sevices;
using Microsoft.AspNetCore.Mvc;

namespace Crud_MVC.Controllers
{
    public class DeleteUser : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IApiService _apiService;

        public DeleteUser(IUserRepository userRepository, IApiService apiService)
        {
            _userRepository = userRepository;
            _apiService = apiService;
        }

        public async Task<ActionResult<UserModel>> Index(int id)
        {   
            UserModel userSearched = await _apiService.GET(id);
            return View(userSearched);
        }

        public async Task<ActionResult> RemoveUser(int id)
        {
            await _apiService.DELETE(id);
            return RedirectToAction("Index", "home");
        }
    }
}
