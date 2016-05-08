using Microsoft.Data.Entity;
using System.Collections.Generic;

namespace EFGetStarted.AspNet5.NewDb.Models
{
    public class ParqueContext : DbContext
    {
        public DbSet<Parque> Parques { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Make Blog.Url required
            modelBuilder.Entity<Parque>()
                .Property(b => b.Nombre)
                .IsRequired();
        }
    }

    public class Parque
    {
        public int ParqueId { get; set; }
        public string Nombre { get; set; }
        public string Barrio { get; set; }
        public string Direccion { get; set; }
        public string Area { get; set; }
    }
}