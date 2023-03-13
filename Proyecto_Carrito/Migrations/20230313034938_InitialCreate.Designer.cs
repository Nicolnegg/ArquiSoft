﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_Carrito.Context;

namespace Proyecto_Carrito.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230313034938_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Proyecto_Carrito.Models.Carrito", b =>
                {
                    b.Property<long>("IdCarrito")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("IdUsuario")
                        .HasColumnType("bigint");

                    b.Property<int>("Totalprecio")
                        .HasColumnType("int");

                    b.Property<int>("Totalproductos")
                        .HasColumnType("int");

                    b.HasKey("IdCarrito");

                    b.ToTable("Carritos");
                });

            modelBuilder.Entity("Proyecto_Carrito.Models.Producto_Carrito", b =>
                {
                    b.Property<long>("IdCarrito")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("CantProducto")
                        .HasColumnType("int");

                    b.Property<long>("IdProducto")
                        .HasColumnType("bigint");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("IdCarrito");

                    b.ToTable("ProductosCarritos");
                });
#pragma warning restore 612, 618
        }
    }
}