﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Anderson_Gomez_Ap1_p1.UI.Registros;
using Anderson_Gomez_Ap1_p1.UI.Consultas;

namespace Anderson_Gomez_Ap1_p1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegistroMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var rProductos = new rProductos();
            rProductos.Show();
        }

        private void ConsultaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var cProductos = new cProductos();
            cProductos.Show();
        }
    }
}
