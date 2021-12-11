﻿// <auto-generated />
using AgenciaViagensMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgenciaViagensMVC.Migrations
{
    [DbContext(typeof(DestinoContext))]
    [Migration("20211211044717_Inital Create")]
    partial class InitalCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgenciaViagensMVC.Models.Destino", b =>
                {
                    b.Property<int>("IdDestino")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CidadeDestino")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("EstadoDestino")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PaisDestino")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("IdDestino");

                    b.ToTable("Destinos");
                });
#pragma warning restore 612, 618
        }
    }
}
