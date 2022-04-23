using Microsoft.EntityFrameworkCore;

namespace UserFormAPI.Models
{
    public class UserFormContext:DbContext
    {
        public UserFormContext(DbContextOptions<UserFormContext> options):base(options)
        {

        }

        public DbSet<UserForm> Users { get; set; }
    }
}
