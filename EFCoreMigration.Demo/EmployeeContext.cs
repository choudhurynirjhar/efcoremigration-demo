using Microsoft.EntityFrameworkCore;

namespace EFCoreMigration.Demo
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions dbContextOptions) 
            : base(dbContextOptions)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
