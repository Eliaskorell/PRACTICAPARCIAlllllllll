
using AccesoDatos1.Models;
using Microsoft.EntityFrameworkCore;


namespace AccesoDatos1.Data
{
    public class AplicationDbContext : DbContext
    {
     
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=biblioteca.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>().HasData(
                new Libro { Id = 1, Titulo = "El Principito", Autor = "Saint-Exupéry", CopiasDisponibles = 3 },
                new Libro { Id = 2, Titulo = "100 Años de Soledad", Autor = "Gabriel García Márquez", CopiasDisponibles = 2 },
                new Libro { Id = 3, Titulo = "Cien Años de Soledad", Autor = "Gabriel García Márquez", CopiasDisponibles = 2 });
            
        }
    
    }
}
