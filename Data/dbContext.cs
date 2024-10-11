using Crud_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_MVC.Data
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> context) : base(context)
        {
        }

        public DbSet<UserModel> Usuarios { get; set; }
    }
}
