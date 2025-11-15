using GestionViajes.Shared.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;



namespace GestionViajes.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Chofer> Choferes { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Entrega> Entregas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relación uno a uno entre Usuario y Chofer
            modelBuilder.Entity<Usuario>()
     .HasOne(u => u.Chofer)
     .WithOne(c => c.Usuario)
     .HasForeignKey<Chofer>(c => c.UsuarioId)
     .IsRequired(false)                        // RELACIÓN OPCIONAL
     .OnDelete(DeleteBehavior.SetNull);         // SI BORRO USUARIO, NO BORRO CHOFER

        }
    }
}
