using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ProyectNatillera.Clases
{
    public class ClsContactosProveedor
    {

        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public ContactosProveedor contactosProveedor { get; set; }

        public ContactosProveedor ConsultarXId(int Id) // Devulve un objeto Cliente
        {

            ContactosProveedor Cl = NatilleraDB.ContactosProveedors.FirstOrDefault(x => x.CodigoContacto == Id);
            return Cl;
        }

        public List<ContactosProveedor> ConsultarTodos()   // Devulve una lista de Cliente
        {

            return NatilleraDB.ContactosProveedors
                .OrderBy(x => x.CodigoContacto)
                .ToList();
        }

        public string Insertar()
        {
            try
            {

                if (contactosProveedor == null)
                {
                    return "Error: No se proporcionó un objeto contacto para insertar.";
                }

                NatilleraDB.ContactosProveedors.Add(contactosProveedor);

                NatilleraDB.SaveChanges();
                return "Contacto insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el contacto: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (contactosProveedor == null)
            {
                return "Error: No se proporcionó un objeto contacto para actualizar.";
            }

            ContactosProveedor cl = ConsultarXId(contactosProveedor.CodigoContacto);

            if (cl == null)
            {
                return "Error: El ID del contacto no es válido o no existe.";
            }

            try
            {

                NatilleraDB.ContactosProveedors.AddOrUpdate(contactosProveedor);

                NatilleraDB.SaveChanges();
                return "Contacto actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el contacto: " + ex.Message;
            }
        }

        public string EliminarXId(int Id)
        {
            try
            {

                ContactosProveedor cl = ConsultarXId(Id);


                if (cl == null)
                {
                    return "Error: Contacto no encontrado con el ID proporcionado.";
                }

                NatilleraDB.ContactosProveedors.Remove(cl);

                NatilleraDB.SaveChanges();

                return "Contacto eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el contacto: " + ex.Message;
            }
        }

    }
}