using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoClub.AccesoDatos.Modelos;

namespace VideoClubExamen.Modelos
{
    public class VideoclubContext : DbContext
    {
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<AlquilerPelicula> AlquilerPeliculas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=videoclub.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AlquilerPelicula>()
                .HasKey(ap => new { ap.AlquilerId, ap.PeliculaId });
        }
    }
}