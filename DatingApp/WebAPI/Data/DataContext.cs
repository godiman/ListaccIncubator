using Microsoft.EntityFrameworkCore;
using WebAPI.Data.Model;
namespace WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base (options)
        {
           
        }

         
         
        protected override void OnModelCreating (ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Users");
        }
        public DbSet<User> users {get; set;}
        public DbSet<Address> Addresses {get; set;}
        

    }
}