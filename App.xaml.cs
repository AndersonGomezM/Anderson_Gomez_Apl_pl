﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Anderson_Gomez_Ap1_p1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs args)
        {
            MessageBox.Show($"Ocurrio un error:( {args.Exception.Message}","Error no controlado", MessageBoxButton.OK, MessageBoxImage.Error);
            args.Handled = true;
        }
    }
}
