using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using EFGetStarted.AspNet5.NewDb.Models;

namespace SampleWebApp.Migrations.Contacto
{
    [DbContext(typeof(ContactoContext))]
    partial class ContactoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("EFGetStarted.AspNet5.NewDb.Models.Contacto", b =>
                {
                    b.Property<int>("ContactoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Telefono");

                    b.HasKey("ContactoId");
                });

            modelBuilder.Entity("EFGetStarted.AspNet5.NewDb.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContactoId");

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("PostId");
                });

            modelBuilder.Entity("EFGetStarted.AspNet5.NewDb.Models.Post", b =>
                {
                    b.HasOne("EFGetStarted.AspNet5.NewDb.Models.Contacto")
                        .WithMany()
                        .HasForeignKey("ContactoId");
                });
        }
    }
}
