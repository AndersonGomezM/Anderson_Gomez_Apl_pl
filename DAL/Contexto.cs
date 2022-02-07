using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Anderson_Gomez_Ap1_p1.Entidades;

namespace Anderson_Gomez_Ap1_p1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos>? Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\ProductosBaseDeDatos.db");
        }
    }
}