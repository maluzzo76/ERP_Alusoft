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
            // Asiento → LineasAsiento
            modelBuilder.Entity<Asiento>()
                .HasMany(a => a.Lineas_Asiento)
                .WithOne()
                .HasForeignKey(l => l.Asiento_Id)
                .OnDelete(DeleteBehavior.Cascade); // Borra las líneas si se borra el asiento

            // Plan_Cuentas → LineasAsiento
            modelBuilder.Entity<LineaAsiento>()
                .HasOne(l => l.Plan_Cuentas)
                .WithMany(p => p.Lineas_Asiento)
                .HasForeignKey(l => l.Plan_CuentasId)
                .OnDelete(DeleteBehavior.Restrict); // Evita borrar cuenta si tiene líneas
        }

        public DbSet<Plan_Cuentas> Plan_Cuentas { get; set; }
        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<LineaAsiento> Lineas_Asiento { get; set; }
    }
}
