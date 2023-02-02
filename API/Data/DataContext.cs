// using Microsoft.EntityFrameworkCore;
namespace API.Data
{
    public class DataContext :DbContext
    {
        public DataContext(Parameters)
        {
            
        }
        public DbSet<AppUser> Users {get; set;}
    }

}