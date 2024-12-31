
using Microsoft.EntityFrameworkCore;
using UniqueEmployeeManagement.Models;

namespace UniqueEmployeeManagement.Data
{
    public class UniqueDbContext : DbContext
    {
        public UniqueDbContext(DbContextOptions<UniqueDbContext> options) : base(options) { }

        public DbSet<EmployeeRecord> Employees { get; set; }
        public DbSet<UserRecord> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<EmployeeRecord>().HasData(
                new EmployeeRecord { Id = 1, Name = "Swaraj Singh", Email = "Swarajsingh@gmail.com", Department = "HR", Position = "Manager", Salary = 75000.00M },
                new EmployeeRecord { Id = 2, Name = "Siddhesh jadhav", Email = "siddheshjadhav@gmail.com", Department = "IT", Position = "Developer", Salary = 60000.00M },
                new EmployeeRecord { Id = 3, Name = "Jayesh Shimpi", Email = "jsyeshshipi@gmail.com", Department = "Finance", Position = "Analyst", Salary = 50000.00M }
            );

         
            modelBuilder.Entity<UserRecord>().HasData(
                new UserRecord { Id = 1, Username = "admin", Password = "password" },
                new UserRecord { Id = 2, Username = "manager", Password = "manager123" }
            );
        }
    }
}
