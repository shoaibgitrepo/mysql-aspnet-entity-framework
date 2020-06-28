using ConsoleApp1.Models;
using MySql.Data.Entity;
using System.Data.Entity;

namespace ConsoleApp1.Persistence
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class SdDbContext : DbContext
    {
        public SdDbContext()
            : base("name=DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
