using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSQLEntity.AccesoDatos;

namespace WPFSQLEntity.LogicaNegocio
{
    public class ContactoMetodos
    {
        #region Contactos
        public List<Contacto> ObtenerContactos()
        {
            using (var conexion = new ModeloAgendaContainer())
            {
                var _contactos = (from c in conexion.Contactos select c);
                return _contactos.ToList();
            }             
        }
     
        public bool GuardarContacto(Contacto entidad)
        {
            try
            {
                ModeloAgendaContainer conexion = new ModeloAgendaContainer();               
                var consulta = (from c in conexion.Contactos where c.Id == entidad.Id select c).FirstOrDefault();
                  if (consulta != null)
                    {
                        consulta.Nombre = entidad.Nombre;
                        consulta.Direccion  = entidad.Direccion;
                        consulta.Telefono = entidad.Telefono;
                        consulta.FechaNacimiento = entidad.FechaNacimiento;
                        consulta.CorreoElectronico = entidad.CorreoElectronico;
                        consulta.Foto = entidad.Foto;
                        consulta.Activo = entidad.Activo; 
                        conexion.SaveChanges();
                        return true;
                    }
                  else
                    {
                        conexion.Contactos.Add(entidad);
                        conexion.SaveChanges();
                        return true;
                    }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
     
        public bool EliminarContacto(Guid id)
        {
            try
            {
                using (var conexion = new ModeloAgendaContainer())
                {
                    var consulta = (from c in conexion.Contactos where c.Id == id select c).FirstOrDefault();
                    if (consulta != null)
                    {
                        conexion.Contactos.Remove(consulta);
                        conexion.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
