using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using ProyectNatillera.Models;

namespace ProyectNatillera.Clases
{
    public class ClsEvento
    {

        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public Evento evento { get; set; }

        //Consulrar Evento por ID
        public Evento ConsultarXId(int Id)
        {
            return NatilleraDB.Eventos.FirstOrDefault(e => e.IdEvento == Id);
        }

        //Consultar todos los Eventos   

        public List<Evento> ConsultarTodos() // Devuelve una lista de Eventos
        {
            return NatilleraDB.Eventos.OrderBy(e => e.Fecha)
        }

        // Insertar Evento
        public string Insertar()
        {
            try
            {
                if (evento == null)
                    return "Error: No se proporcionó un evento para insertar.";
                NatilleraDB.Eventos.Add(evento);
                NatilleraDB.SaveChanges();
                return "Evento insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el evento: " + ex.Message;
            }
        }


        // Actualizar Evento

        public string Actualizar()
        {
            try
            {
                if (evento == null)
                    return "Error: No se proporcionó un evento para actualizar.";
                Evento ev = ConsultarXId(evento.IdEvento);
                if (ev == null)
                    return "Error: El evento no existe o el ID es incorrecto.";
                NatilleraDB.Eventos.AddOrUpdate(evento);
                NatilleraDB.SaveChanges();
                return "Evento actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el evento: " + ex.Message;
            }
        }

        // Eliminar Evento por ID

        public string EliminarXId(int id)
        {
            try
            {
                Evento ev = ConsultarXId(id);
                if (ev == null)
                    return "Error: No se encontró el evento con el ID proporcionado o el ID es invalido.";
                NatilleraDB.Eventos.Remove(ev);
                NatilleraDB.SaveChanges();
                return "Evento eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el evento: " + ex.Message;
            }

        }

        // Consultar por fecha

        public List<Evento> ConsultarPorFecha(DateTime fecha)
        {
            return NatilleraDB.Eventos.Where(e => e.Fecha.Date == fecha.Date).ToList();

        }
    }
}