using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Anderson_Gomez_Ap1_p1.Entidades;
using Anderson_Gomez_Ap1_p1.BLL;

namespace Anderson_Gomez_Ap1_p1.UI.Registros
{
    public partial class rProductos : Window
    {
        private Productos productos = new Productos();
        
        public rProductos()
        {
            InitializeComponent();
            this.DataContext = productos;
        }

        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = this.productos;
        }

        private void Limpiar()
        {
            this.productos = new Productos();
            this.DataContext = productos;
        }

        private bool Validar()
        {
            bool confirmar = true;

            if(string.IsNullOrWhiteSpace(productos.Descripcion))
            {
                confirmar = false;
                DescripcionTextBox.Focus();
                MessageBox.Show("Ha sucedido un error, debe inidcar la descripción", "Corrección",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if(string.IsNullOrWhiteSpace(Convert.ToString(productos.Existencia)))
            {
                confirmar = false;
                ExistenciaTextBox.Focus();
                MessageBox.Show("Ha sucedido un error, debe inidcar la existencia", "Corrección",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if(string.IsNullOrWhiteSpace(Convert.ToString(productos.Costo)))
            {
                confirmar = false;
                CostoTextBox.Focus();
                MessageBox.Show("Ha sucedido un error, debe inidcar el costo", "Corrección",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return confirmar;
        }

        private void ExistenciaTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void CostoTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void CostoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textB = sender as TextBlock;
            CalcularValorInventario();
        }

        private void CalcularValorInventario()
        {
            productos.ValorInventario = Convert.ToDecimal(ExistenciaTextBox.Text) * Convert.ToDecimal(CostoTextBox.Text);

            ValorInventarioTextBox.Text = Convert.ToString(productos.ValorInventario);
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var confirmar = ProductosBLL.Buscar(this.productos.ProductoId);

            if (confirmar != null)
            {
                this.productos = confirmar;
                Cargar();
            }
            else
            {
                Limpiar();
                MessageBox.Show("¡¡No se puedo encontrar el producto!!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }


        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if(!Validar())
                return;
            
            bool confirmar = false;

            CalcularValorInventario();
            
            confirmar = ProductosBLL.Guardar(productos);

            if (confirmar)
            {
                MessageBox.Show("Se puedo guardar el producto", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("¡¡No se puedo guardar el producto!!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if(ProductosBLL.Eliminar(Convert.ToInt32(ProductoIdTextBox.Text)))
            {
                MessageBox.Show("Se guardo con exito el producto", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("¡¡No se fue posible eliminar el producto!!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}