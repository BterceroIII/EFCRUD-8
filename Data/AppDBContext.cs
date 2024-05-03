using Microsoft.EntityFrameworkCore;
using EFCRUD8.Models;

namespace EFCRUD8.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {
            
        }

        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Empleado>(tb =>
            {
                tb.HasKey(col => col.IdEmpleado);

                tb.Property(col => col.IdEmpleado)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.Nombre).HasMaxLength(20);
                tb.Property(col => col.Apellido).HasMaxLength(20);
                tb.Property(col => col.Correo).HasMaxLength(50);
            });

            modelBuilder.Entity<Empleado>().ToTable("Empleado");
        }
    }
}
