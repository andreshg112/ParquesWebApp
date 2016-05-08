using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using EFGetStarted.AspNet5.NewDb.Models;

namespace SampleWebApp.Migrations.Parque
{
    [DbContext(typeof(ParqueContext))]
    partial class ParqueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("EFGetStarted.AspNet5.NewDb.Models.Parque", b =>
                {
                    b.Property<int>("ParqueId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Area");

                    b.Property<string>("Barrio");

                    b.Property<string>("Direccion");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("ParqueId");
                });
        }
    }
}
