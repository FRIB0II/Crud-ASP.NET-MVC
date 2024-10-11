using Crud_MVC.Models;

namespace Crud_MVC.Repository.Interfaces
{
    public interface IUserRepository
    {
        UserModel AddUser(UserModel user);
        UserModel UpdateUser(UserModel user);
        UserModel GetUser(int id);
        bool DeleteUser(int id);
        List<UserModel> GetAllUsers();
    }
}
