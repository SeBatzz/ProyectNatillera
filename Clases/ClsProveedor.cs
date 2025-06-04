using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ProyectNatillera.Models;

namespace ProyectNatillera.Clases
{
    public class ClsProveedor
    {
        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public Proveedore proveedor { get; set; }

        public Proveedore ConsultarXId(int id)
        {
            return NatilleraDB.Proveedores.FirstOrDefault(x => x.idProveedor == id);

        }

        public List<Proveedore> ConsultarTodos()
        {
            return NatilleraDB.Proveedores.OrderBy(x => x.NombreProveedor).ToList();
        }

        public string Insertar()
        {
            try
            {
                if (proveedor == null)
                {
                    return "Error: No se proporcionó un objeto Proveedor para insertar.";
                }

                NatilleraDB.Proveedores.Add(proveedor);
                NatilleraDB.SaveChanges();

                return "Proveedor insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el proveedor: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            if (proveedor == null)
            {
                return "Error: No se proporcionó un objeto Proveedor para actualizar.";
            }

            Proveedore pr = ConsultarXId(proveedor.idProveedor);

            if (pr == null)
            {
                return "Error: El ID del proveedor no es válido o no existe.";
            }

            try
            {
                NatilleraDB.Proveedores.AddOrUpdate(proveedor);
                NatilleraDB.SaveChanges();

                return "Proveedor actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el proveedor: " + ex.Message;
            }
        }

        public string EliminarXId(int id)
        {
            try
            {
                Proveedore pr = ConsultarXId(id);

                if (pr == null)
                {
                    return "Error: Proveedor no encontrado con el ID proporcionado.";
                }

                NatilleraDB.Proveedores.Remove(pr);
                NatilleraDB.SaveChanges();

                return "Proveedor eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el proveedor: " + ex.Message;
            }
        }


    }
}