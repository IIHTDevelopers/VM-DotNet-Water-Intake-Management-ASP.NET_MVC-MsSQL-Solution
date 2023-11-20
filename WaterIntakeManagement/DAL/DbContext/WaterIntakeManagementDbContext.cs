
using WaterIntakeManagement.Models;
using System.Data.Entity;

namespace WaterIntakeManagement.DAL
{
    public class WaterIntakeManagementDbContext : DbContext
    {
        public WaterIntakeManagementDbContext()
            : base("name=DefaultConnection")
        {
        }
        public DbSet<WaterIntake> WaterIntakes { get; set; }
    }
}