using HumanResource.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace HumanResource.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

    }
}