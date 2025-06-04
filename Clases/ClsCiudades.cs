using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ProyectNatillera.Clases
{
    public class ClsCiudades
    {

        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public Ciudade ciudades{ get; set; }

        public Ciudade ConsultarXId(int Id) // Devulve un objeto Cliente
        {

            Ciudade Cl = NatilleraDB.Ciudades.FirstOrDefault(x => x.CodigoCiudad == Id);
            return Cl;
        }

        public List<Ciudade> ConsultarTodos()   // Devulve una lista de Cliente
        {

            return NatilleraDB.Ciudades
                .OrderBy(x => x.CodigoCiudad)
                .ToList();
        }

        public string Insertar()
        {
            try
            {

                if (ciudades == null)
                {
                    return "Error: No se proporcionó un objeto Ciudad para insertar.";
                }

                NatilleraDB.Ciudades.Add(ciudades);

                NatilleraDB.SaveChanges();
                return "Ciudad insertada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar la ciudad: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (ciudades == null)
            {
                return "Error: No se proporcionó un objeto ciudad para actualizar.";
            }

            Ciudade cl = ConsultarXId(ciudades.CodigoCiudad);

            if (cl == null)
            {
                return "Error: El ID de la ciudad no es válido o no existe.";
            }

            try
            {

                NatilleraDB.Ciudades.AddOrUpdate(ciudades);
                NatilleraDB.SaveChanges();
                return "Ciudades actualizada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el cliente: " + ex.Message;
            }
        }

        public string EliminarXId(int Id)
        {
            try
            {

                Ciudade cl = ConsultarXId(Id);


                if (cl == null)
                {
                    return "Error: Ciudad no encontrado con el ID proporcionado.";
                }

                NatilleraDB.Ciudades.Remove(cl);

                NatilleraDB.SaveChanges();

                return "Ciudad eliminada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la ciudad: " + ex.Message;
            }
        }

    }
}