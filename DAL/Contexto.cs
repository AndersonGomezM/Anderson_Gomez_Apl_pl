using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Anderson_Gomez_Ap1_p1.DAL
{
    public class Contexto:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=Data\BaseDeDatos.db");
    }
    }
}