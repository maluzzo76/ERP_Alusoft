using ERP_Alusoft.Model;
using Microsoft.EntityFrameworkCore;

namespace ERP_Alusoft.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<Plan_Cuentas> Plan_Cuentas { get; set; }
        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<LineaAsiento> Lineas_Asiento { get; set; }
    }
}
