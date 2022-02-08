using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Anderson_Gomez_Ap1_p1.Entidades;
using Anderson_Gomez_Ap1_p1.BLL;

namespace Anderson_Gomez_Ap1_p1.UI.Consultas
{
    public partial class cProductos : Window
    {

        public cProductos()
        {
            InitializeComponent();
            var lista = ProductosBLL.GetProductos();
            ProductosDataGrid.ItemsSource = lista;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var lista = new List<Productos>();

            if(string.IsNullOrWhiteSpace(CriterioTextBox.Text))
                lista = ProductosBLL.GetList(e => true);
            else
            {
                switch(FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        lista = ProductosBLL.GetList(e => e.Descripcion.Contains(CriterioTextBox.Text));
                        break;
                }
            }

            ProductosDataGrid.ItemsSource = null;
            ProductosDataGrid.ItemsSource = lista;
        }
    }
}