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
using WPFSQLEntity.AccesoDatos;

namespace WPFSQLEntity.WPF
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

        private void ListadoContactos_Click(object sender, EventArgs e)
        {
            Contactos.ContactoForm _nuevoContacto = new Contactos.ContactoForm();
            Contacto contacto = new Contacto();
            contacto.Id = Guid.NewGuid();
            _nuevoContacto.Entidad = contacto;
            DetalleGrid.Children.Clear();
            DetalleGrid.Children.Add(_nuevoContacto);
            _nuevoContacto.Guardar += (se, ev) =>
                {
                    listadoContactos.MostrarContactos();
                    DetalleGrid.Children.Clear();
                };
            _nuevoContacto .Cancelar+= (se, ev) =>
                {                  
                    DetalleGrid.Children.Clear();
                };
        }

        private void listadoContactos_Seleccionado_1(object sender, Contacto e)
        {
            
        }

        private void listadoContactos_Editar_1(object sender, Contacto e)
        {
            Contactos.ContactoForm _nuevoContacto = new Contactos.ContactoForm();
            _nuevoContacto.Entidad = e;
            DetalleGrid.Children.Clear();
            DetalleGrid.Children.Add(_nuevoContacto);
            _nuevoContacto.Guardar += (se, ev) =>
            {
                listadoContactos.MostrarContactos();
                DetalleGrid.Children.Clear();
            };
            _nuevoContacto.Cancelar += (se, ev) =>
            {
                DetalleGrid.Children.Clear();
            };
        }
    }
}
