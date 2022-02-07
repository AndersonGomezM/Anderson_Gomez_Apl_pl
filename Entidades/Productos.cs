using System;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Anderson_Gomez_Ap1_p1.Entidades
{
    public class Productos
    {
        [Key]

        public int ProductoId { get; set; }
        public string? Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Costo { get; set;}
        public decimal ValorInventario { get; set; }
    }
}