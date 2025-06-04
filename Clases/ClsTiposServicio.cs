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
        public TiposServicio tipoServicio { get; set; }

        public TiposServicio ConsultarXId(int id)
        {
            return NatilleraDB.TiposServicio.FirstOrDefault(x => x.CodigoTipoServicio == id);
        }

        public List<TiposServicio> ConsultarTodos()
        {
            return NatilleraDB.TiposServicio.OrderBy(x => x.CodigoTipoServicio).ToList();
        }

        public string Insertar()
        {
            try
            {
                if (tipoServicio == null)
                {
                    return "Error: No se proporcionó un  Tipo de Servicio para insertar.";
                }

                NatilleraDB.TiposServicio.Add(tipoServicio);
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

            TiposServicio ts = ConsultarXId(tipoServicio.CodigoTipoServicio);

            if (ts == null)
            {
                return "Error: El ID del tipo de servicio no es válido o no existe.";
            }

            try
            {
                NatilleraDB.TiposServicio.AddOrUpdate(tipoServicio);
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
                TiposServicio ts = ConsultarXId(id);

                if (ts == null)
                {
                    return "Error: Tipo de servicio no encontrado con el ID proporcionado.";
                }

                NatilleraDB.TiposServicio.Remove(ts);
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