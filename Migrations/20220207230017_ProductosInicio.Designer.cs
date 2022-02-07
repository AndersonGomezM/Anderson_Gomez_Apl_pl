﻿// <auto-generated />
using Anderson_Gomez_Ap1_p1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Anderson_Gomez_Ap1_p1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220207230017_ProductosInicio")]
    partial class ProductosInicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("Anderson_Gomez_Ap1_p1.Entidades.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ValorInventario")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductoId");

                    b.ToTable("Entidades");
                });
#pragma warning restore 612, 618
        }
    }
}
