﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApi.Model;

#nullable disable

namespace TodoApi.Migrations
{
    [DbContext(typeof(DbContextApi))]
    partial class DbContextApiModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TodoApi.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("Apellido");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Email");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime")
                        .HasColumnName("FechaNacimiento");

                    b.Property<string>("Nombre")
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("Nombre");

                    b.Property<decimal?>("Salario")
                        .HasColumnType("decimal")
                        .HasColumnName("Salario");

                    b.Property<string>("Telefono")
                        .HasMaxLength(15)
                        .HasColumnType("varchar")
                        .HasColumnName("Telefono");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("TodoApi.Model.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(30)
                        .HasColumnType("varchar")
                        .HasColumnName("Descripcion");

                    b.Property<DateTime?>("FechaVencimiento")
                        .HasColumnType("datetime")
                        .HasColumnName("FechaVencimiento");

                    b.Property<decimal>("Impuesto")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Impuesto");

                    b.Property<decimal>("PrecioBase")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("PrecioBase");

                    b.Property<string>("Rubro")
                        .HasMaxLength(15)
                        .HasColumnType("varchar")
                        .HasColumnName("Rubro");

                    b.Property<decimal>("Stock")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Stock");

                    b.Property<decimal>("StockMinimo")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("StockMinimo");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
