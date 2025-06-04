using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ProyectNatillera.Clases
{
    public class EventosProveedores
    {

        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public EventosProveedore eventoProveedor { get; set; }

        //Consultar Evento por ID

        public EventosProveedore ConsultarXId(int Id)
        {
            EventosProveedore Cl = NatilleraDB.EventosProveedores.FirstOrDefault(x => x.CodigoRelacion == Id);
            return Cl;
        }

        //Consultar todos los Eventos 

        public List<EventosProveedore> ConsultarTodos()   // Devulve una lista de Cliente
        {

            return NatilleraDB.EventosProveedores
                .OrderBy(x => x.FechaContratacion)
                .ToList();
        }

        //Insertar Evento
        public string Insertar()
        {
            try
            {

                if (eventoProveedor == null)
                {
                    return "Error: No se proporcionó un objeto evento para insertar.";
                }

                NatilleraDB.EventosProveedores.Add(eventoProveedor);

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

            if (eventoProveedor == null)
            {
                return "Error: No se proporcionó un objeto Evento para actualizar.";
            }

            EventosProveedore cl = ConsultarXId(eventoProveedor.CodigoRelacion);

            if (cl == null)
            {
                return "Error: El ID del Evento no es válido o no existe.";
            }

            try
            {

                NatilleraDB.EventosProveedores.AddOrUpdate(eventoProveedor);

                NatilleraDB.SaveChanges();
                return "Evento actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el evento: " + ex.Message;
            }
        }


        // Eliminar Evento por ID

        public string EliminarXId(int Id)
        {
            try
            {

                EventosProveedore prv = ConsultarXId(Id);


                if (prv == null)
                {
                    return "Error: Evento no encontrado con el ID proporcionado.";
                }

                NatilleraDB.EventosProveedores.Remove(prv);

                NatilleraDB.SaveChanges();

                return "Evento eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el evento: " + ex.Message;
            }
        }
        // Consultar por fechaEvento

        public List<EventosProveedore> ConsultarPorFecha(DateTime fecha)
        {
            return NatilleraDB.EventosProveedores.Where(e => e.FechaContratacion == fecha.Date).ToList();

        }

    }
}