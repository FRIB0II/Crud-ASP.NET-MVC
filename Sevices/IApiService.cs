using Crud_MVC.Models;

namespace Crud_MVC.Sevices
{
    public interface IApiService
    {
        Task<UserModel> POST(UserModel model);
        Task<UserModel> GET(int id);
        Task<UserModel> UPDATE(UserModel model);
        Task DELETE(int id);
        Task<List<UserModel>> GETALL();
    }
}
