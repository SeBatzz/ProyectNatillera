using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ProyectNatillera.Models;

namespace ProyectNatillera.Clases
{
    public class ClsTiposServicio
    {
        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public TiposServicioProveedor tipoServicio { get; set; }

        public TiposServicioProveedor ConsultarXId(int id)
        {
            return NatilleraDB.TiposServicioProveedors.FirstOrDefault(x => x.CodigoTipoServicio == id);
        }

        public List<TiposServicioProveedor> ConsultarTodos()
        {
            return NatilleraDB.TiposServicioProveedors.OrderBy(x => x.CodigoTipoServicio).ToList();
        }

        public string Insertar()
        {
            try
            {
                if (tipoServicio == null)
                {
                    return "Error: No se proporcionó un  Tipo de Servicio para insertar.";
                }

                NatilleraDB.TiposServicioProveedors.Add(tipoServicio);
                NatilleraDB.SaveChanges();

                return "Tipo de servicio insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el tipo de servicio: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            if (tipoServicio == null)
            {
                return "Error: No se proporcionó un  Tipo de Servicio para actualizar.";
            }

            TiposServicioProveedor ts = ConsultarXId(tipoServicio.CodigoTipoServicio);

            if (ts == null)
            {
                return "Error: El ID del tipo de servicio no es válido o no existe.";
            }

            try
            {
                NatilleraDB.TiposServicioProveedors.AddOrUpdate(tipoServicio);
                NatilleraDB.SaveChanges();

                return "Tipo de servicio actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el tipo de servicio: " + ex.Message;
            }
        }

        public string EliminarXId(int id)
        {
            try
            {
                TiposServicioProveedor ts = ConsultarXId(id);

                if (ts == null)
                {
                    return "Error: Tipo de servicio no encontrado con el ID proporcionado.";
                }

                NatilleraDB.TiposServicioProveedors.Remove(ts);
                NatilleraDB.SaveChanges();

                return "Tipo de servicio eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el tipo de servicio: " + ex.Message;
            }
        }
    }
}