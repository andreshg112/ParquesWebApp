using Microsoft.Data.Entity;
using System.Collections.Generic;

namespace EFGetStarted.AspNet5.NewDb.Models
{
    public class ContactoContext : DbContext
    {
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Make Blog.Url required
            modelBuilder.Entity<Contacto>()
                .Property(b => b.Nombre)
                .IsRequired();
        }
    }

    public class Contacto
    {
        public int ContactoId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int ContactoId { get; set; }
        public Contacto Contacto { get; set; }
    }
}