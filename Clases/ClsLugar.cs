using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using ProyectNatillera.Models;

namespace ProyectNatillera.Clases
{
    public class ClsLugar
    {
        private NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public Lugare lugar { get; set; }

        //Agregar Lugar

        public Lugare ConsultarXId(int Id) // Devulve un objeto Cliente
        {

            Lugare Lg = NatilleraDB.Lugares.FirstOrDefault(x => x.CodigoLugar == Id);
            return Lg;
        }

        public List<Lugare> ConsultarTodos()   // Devulve una lista de Cliente
        {

            return NatilleraDB.Lugares
                .OrderBy(x => x.CodigoLugar)
                .ToList();
        }

        public string Insertar()
        {
            try
            {

                if (lugar == null)
                {
                    return "Error: No se proporcionó un objeto Lugar para insertar.";
                }

                NatilleraDB.Lugares.Add(lugar);

                NatilleraDB.SaveChanges();
                return "Lugar insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el lugar: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (lugar == null)
            {
                return "Error: No se proporcionó un objeto Cliente para actualizar.";
            }

            Lugare lg = ConsultarXId(lugar.CodigoLugar);

            if (lg == null)
            {
                return "Error: El ID del lugar no es válido o no existe.";
            }

            try
            {
                NatilleraDB.Lugares.AddOrUpdate(lugar);
                NatilleraDB.SaveChanges();
                return "Lugar actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el lugar: " + ex.Message;
            }
        }

        public string EliminarXId(int Id)
        {
            try
            {

                Lugare lg = ConsultarXId(Id);

                if (lg == null)
                {
                    return "Error: Lugar no encontrado con el ID proporcionado.";
                }

                NatilleraDB.Lugares.Remove(lg);

                NatilleraDB.SaveChanges();

                return "Lugar eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el lugar: " + ex.Message;
            }
        }
    }
}