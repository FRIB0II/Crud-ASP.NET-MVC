using Crud_MVC.Data;
using Crud_MVC.Models;
using Crud_MVC.Repository.Interfaces;

namespace Crud_MVC.Repository.DataRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly dbContext _dbContext;

        public UserRepository(dbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UserModel AddUser(UserModel user)
        {
            _dbContext.Usuarios.Add(user);
            _dbContext.SaveChanges();
            return user;
        }

        public UserModel GetUser(int id)
        {
           UserModel? UserSearched = _dbContext.Usuarios.FirstOrDefault(x => x.Id == id);

            if (UserSearched == null) 
            {
                throw new Exception("User not found");
            }
            else
            {
                return UserSearched;
            }
        }

        public UserModel UpdateUser(UserModel user)
        {
            UserModel? UserSearched = _dbContext.Usuarios.FirstOrDefault(x => x.Id == user.Id);

            if (UserSearched == null)
            {
                throw new Exception("User not found");
            }
            else
            {
                UserSearched.UserName = user.UserName;
                UserSearched.UserLastName = user.UserLastName;
                UserSearched.UserEmail = user.UserEmail;
                UserSearched.UserPassword = user.UserPassword;

                _dbContext.SaveChanges();

                return user;
            }
        }

        public bool DeleteUser(int id)
        {
            UserModel? UserSearched = _dbContext.Usuarios.FirstOrDefault(x => x.Id == id);

            if (UserSearched == null)
            {
                return false;
            }
            else
            {   
                _dbContext.Usuarios.Remove(UserSearched);
                _dbContext.SaveChanges();
                return true;
            }
        }

        public List<UserModel> GetAllUsers()
        {   
            return _dbContext.Usuarios.ToList();
        }
    }
}
