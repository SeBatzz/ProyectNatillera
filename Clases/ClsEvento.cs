﻿using System;
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

        //Consultar Evento por ID

        public Evento ConsultarXId(int Id)
        {
            Evento Cl = NatilleraDB.Eventos.FirstOrDefault(x => x.CodigoEvento == Id);
            return Cl;
        }

        //Consultar todos los Eventos 

        public List<Evento> ConsultarTodos()   // Devulve una lista de Cliente
        {

            return NatilleraDB.Eventos
                .OrderBy(x => x.FechaCreacion)
                .ToList();
        }

        //Insertar Evento
        public string Insertar()
        {
            try
            {

                if (evento == null)
                {
                    return "Error: No se proporcionó un objeto evento para insertar.";
                }

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

            if (evento == null)
            {
                return "Error: No se proporcionó un objeto Evento para actualizar.";
            }

            Evento cl = ConsultarXId(evento.CodigoEvento);

            if (cl == null)
            {
                return "Error: El ID del Evento no es válido o no existe.";
            }

            try
            {

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

        public string EliminarXId(int Id)
        {
            try
            {

                Evento cl = ConsultarXId(Id);


                if (cl == null)
                {
                    return "Error: Evento no encontrado con el ID proporcionado.";
                }

                NatilleraDB.Eventos.Remove(cl);

                NatilleraDB.SaveChanges();

                return "Evento eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el evento: " + ex.Message;
            }
        }
        // Consultar por fechaEvento

        public List<Evento> ConsultarPorFecha(DateTime fecha)
        {
            return NatilleraDB.Eventos.Where(e => e.FechaInicio == fecha.Date).ToList();

        }
    }
}