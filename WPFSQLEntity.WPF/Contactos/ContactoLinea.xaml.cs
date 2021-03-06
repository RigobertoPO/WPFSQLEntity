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
using WPFSQLEntity.AccesoDatos;

namespace WPFSQLEntity.WPF.Contactos
{
    /// <summary>
    /// Interaction logic for ContactoLinea.xaml
    /// </summary>
    public partial class ContactoLinea : UserControl
    {
        public ContactoLinea()
        {
            InitializeComponent();
        }
        public event SeleccionadoEventHandler Eliminar;
        public event SeleccionadoEventHandler Editar;
        public event SeleccionadoEventHandler Seleccionado;
        public delegate void SeleccionadoEventHandler(object sender, Contacto e);
        public Contacto Entidad
        {
            get
            {
                try
                {
                    return this.DataContext as Contacto;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            set
            {
                this.DataContext = value;
                if (value.Nombre != "")
                {
                    NombreTextBlock.Text = value.Nombre;
                    TelefonoTextBlock.Text = value.Telefono;

                }
            }
        }

        private void EditarImage_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (Editar != null)
            {
                Editar(this, Entidad);
            }
        }

        private void EliminarImage_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (Eliminar != null)
            {
                Eliminar(this, Entidad);
            }
        }

        private void StackPanel_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (Seleccionado != null)
            {
                Seleccionado(this, Entidad);
            }
        }
    }
}
