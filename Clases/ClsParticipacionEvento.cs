using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ProyectNatillera.Models;

namespace ProyectNatillera.Clases
{
    public class ClsParticipacionEvento
    {
        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public ParticipacionEvento participacion { get; set; }

        public ParticipacionEvento ConsultarXId(int id)
        {
            return NatilleraDB.ParticipacionEventos.FirstOrDefault(x => x.CodigoParticipacion == id);
        }

        public List<ParticipacionEvento> ConsultarTodos()
        {
            return NatilleraDB.ParticipacionEventos
                .OrderBy(x => x.CodigoParticipacion)
                .ToList();
        }

        public string Insertar()
        {
            try
            {
                if (participacion == null)
                {
                    return "Error: No se proporcionó una participación para insertar.";
                }

                NatilleraDB.ParticipacionEventos.Add(participacion);
                NatilleraDB.SaveChanges();

                return "Participación insertada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar la participación: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                if (participacion == null)
                {
                    return "Error: No se proporcionó una participación para actualizar.";
                }

                var existente = ConsultarXId(participacion.CodigoParticipacion);

                if (existente == null)
                {
                    return "Error: La participación no existe.";
                }

                NatilleraDB.ParticipacionEventos.AddOrUpdate(participacion);
                NatilleraDB.SaveChanges();

                return "Participación actualizada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la participación: " + ex.Message;
            }
        }

        public string EliminarXId(int id)
        {
            try
            {
                var participacionEliminar = ConsultarXId(id);

                if (participacionEliminar == null)
                {
                    return "Error: Participación no encontrada.";
                }

                NatilleraDB.ParticipacionEventos.Remove(participacionEliminar);
                NatilleraDB.SaveChanges();

                return "Participación eliminada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la participación: " + ex.Message;
            }
        }
    }
}
