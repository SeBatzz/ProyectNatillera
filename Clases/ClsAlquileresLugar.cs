using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using ProyectNatillera.Models;

namespace ProyectNatillera.Clases
{
    public class ClsAlquileresLugar
    {

        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public AlquileresLugar alquileresLugar { get; set; }

        public AlquileresLugar ConsultarXId(int Id)
        {
            AlquileresLugar al = NatilleraDB.AlquileresLugars.FirstOrDefault(x => x.CodigoAlquiler == Id);
            return al;
        }

        public List<AlquileresLugar> ConsultarTodos()   // Devulve una lista de Cliente
        {

            return NatilleraDB.AlquileresLugars
                .OrderBy(x => x.CodigoAlquiler)
                .ToList();
        }

        public string Insertar()
        {
            try
            {

                if (alquileresLugar == null)
                {
                    return "Error: No se proporcionó un objeto alquiler para insertar.";
                }

                NatilleraDB.AlquileresLugars.Add(alquileresLugar);

                NatilleraDB.SaveChanges();
                return "Alquiler insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el alquiler: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (alquileresLugar == null)
            {
                return "Error: No se proporcionó un objeto alquiler para actualizar.";
            }

            AlquileresLugar cl = ConsultarXId(alquileresLugar.CodigoAlquiler);

            if (cl == null)
            {
                return "Error: El ID del alquiler no es válido o no existe.";
            }

            try
            {

                NatilleraDB.AlquileresLugars.AddOrUpdate(alquileresLugar);

                NatilleraDB.SaveChanges();
                return "alquiler actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el alquiler: " + ex.Message;
            }
        }

        public string EliminarXId(int Id)
        {
            try
            {

                AlquileresLugar cl = ConsultarXId(Id);


                if (cl == null)
                {
                    return "Error: alquiler no encontrado con el ID proporcionado.";
                }

                NatilleraDB.AlquileresLugars.Remove(cl);

                NatilleraDB.SaveChanges();

                return "alquiler eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el alquiler: " + ex.Message;
            }
        }


    }
}