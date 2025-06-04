using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ProyectNatillera.Clases
{
    public class ClsGastosEvento
    {

        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public GastosEvento gastosEvento { get; set; }

        public GastosEvento ConsultarXId(int Id) 
        {

            GastosEvento Cl = NatilleraDB.GastosEventoes.FirstOrDefault(x => x.CodigoGasto == Id);
            return Cl;
        }

        public List<GastosEvento> ConsultarTodos()  
        {

            return NatilleraDB.GastosEventoes
                .OrderBy(x => x.CodigoGasto)
                .ToList();
        }

        public string Insertar()
        {
            try
            {

                if (gastosEvento == null)
                {
                    return "Error: No se proporcionó un objeto Gastoo Evento para insertar.";
                }

                NatilleraDB.GastosEventoes.Add(gastosEvento);

                NatilleraDB.SaveChanges();
                return "Gasto insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el Gasto: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (gastosEvento == null)
            {
                return "Error: No se proporcionó un objeto Gasto Evento para actualizar.";
            }

            GastosEvento cl = ConsultarXId(gastosEvento.CodigoGasto);

            if (cl == null)
            {
                return "Error: El ID del Gasto no es válido o no existe.";
            }

            try
            {

                NatilleraDB.GastosEventoes.AddOrUpdate(gastosEvento);

                NatilleraDB.SaveChanges();
                return "Gasto actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el gasto: " + ex.Message;
            }
        }

        public string EliminarXId(int Id)
        {
            try
            {

                GastosEvento cl = ConsultarXId(Id);


                if (cl == null)
                {
                    return "Error: Gasto no encontrado con el ID proporcionado.";
                }

                NatilleraDB.GastosEventoes.Remove(cl);

                NatilleraDB.SaveChanges();

                return "Gasto eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el gasto: " + ex.Message;
            }
        }
    }
}