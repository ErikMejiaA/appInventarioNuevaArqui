﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(appInventarioNuevaArquiContext))]
    [Migration("20230802125440_InitialCreateV2")]
    partial class InitialCreateV2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Pais", b =>
                {
                    b.Property<string>("IdCodigo")
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("NombrePais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdCodigo");

                    b.HasIndex("NombrePais")
                        .IsUnique();

                    b.ToTable("Paises", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}