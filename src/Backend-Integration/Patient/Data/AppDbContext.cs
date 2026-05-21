using Patient.Models;
using Microsoft.EntityFrameworkCore;
namespace Patient.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        //public DbSet<Patient> Patients { get; set; }

        public DbSet<LabResult> LabResults { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<Vital> Vitals { get; set; }

        public DbSet<Invoice> Invoices { get; set; }
    }
}
