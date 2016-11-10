using System;
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
using WPFSQLEntity.LogicaNegocio;

namespace WPFSQLEntity.WPF.Contactos
{
    /// <summary>
    /// Interaction logic for ContactosUC.xaml
    /// </summary>
    public partial class ContactosUC : UserControl
    {
        public ContactosUC()
        {
            InitializeComponent();
        }

        public event EventHandler NuevoContacto;
        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            MostrarContactos();
           

        }

        public void MostrarContactos()
        {
            ContactosStackPanel.Children.Clear();
            ContactoMetodos _metodos = new ContactoMetodos();
            var listaContactos = _metodos.ObtenerContactos();
            foreach (var item in listaContactos)
            {
                ContactoLinea _linea = new ContactoLinea();
                _linea.Entidad = item;
                ContactosStackPanel.Children.Add(_linea );
            }
        }

        private void NuevoButton_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (NuevoContacto != null)
            { NuevoContacto(this, new EventArgs()); }
        }
    }
}
