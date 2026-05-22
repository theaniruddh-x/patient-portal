using Microsoft.EntityFrameworkCore;
using PatientPortal.API.Models;

namespace PatientPortal.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Patient> Patients { get; set; }
    }
}