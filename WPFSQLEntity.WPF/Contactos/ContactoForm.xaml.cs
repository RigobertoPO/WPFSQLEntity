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
using WPFSQLEntity.LogicaNegocio;

namespace WPFSQLEntity.WPF.Contactos
{
    /// <summary>
    /// Interaction logic for ContactoForm.xaml
    /// </summary>
    public partial class ContactoForm : UserControl
    {
        public ContactoForm()
        {
            InitializeComponent();
        }
        public event EventHandler Cancelar;
        public event EventHandler Guardar;
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
                   NombreTextBox.Text = value.Nombre;
                   DireccionTextBox.Text  = value.Direccion;
                   TelefonoTextBox.Text = value.Telefono;
                }
            }
        }

        private void AceptarButton_Click_1(object sender, RoutedEventArgs e)
        {
            Entidad.Nombre = NombreTextBox.Text;
            Entidad.Direccion = DireccionTextBox.Text;
            Entidad.Telefono = TelefonoTextBox.Text;
            Entidad.FechaNacimiento = FechaNacimientoDatePicker.SelectedDate;
            Entidad.Activo = ActivoCheckBox.IsChecked;
            ContactoMetodos _metodos = new ContactoMetodos();
            var resultado = _metodos.GuardarContacto(Entidad );
            if (resultado)
            {
                if (Guardar != null)
                { Guardar(this, new EventArgs()); }
            }    
        }

        private void CancelarButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (Cancelar != null)
            { Cancelar(this, new EventArgs()); }
        }
    }
}
