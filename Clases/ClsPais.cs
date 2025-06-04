using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ProyectNatillera.Clases
{
    public class ClsPais
    {
        private NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public Pais pais { get; set; }

        public Pais ConsultarXId(int Id) 
        {

            Pais ps = NatilleraDB.Paises.FirstOrDefault(x => x.CodigoPais == Id);
            return ps;
        }

        public List<Pais> ConsultarTodos()
        {

            return NatilleraDB.Paises
                .OrderBy(x => x.CodigoPais)
                .ToList();
        }

        public string Insertar()
        {
            try
            {

                if (pais == null)
                {
                    return "Error: No se proporcionó un objeto pais para insertar.";
                }

                NatilleraDB.Paises.Add(pais);
                NatilleraDB.SaveChanges();

                return "Pais insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el pais: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (pais == null)
            {
                return "Error: No se proporcionó un objeto Pais para actualizar.";
            }

            Pais ps = ConsultarXId(pais.CodigoPais);

            if (ps == null)
            {
                return "Error: El ID del Pais no es válido o no existe.";
            }

            try
            {

                NatilleraDB.Paises.AddOrUpdate(pais);

                NatilleraDB.SaveChanges();
                return "Pais actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el pais: " + ex.Message;
            }
        }

        public string EliminarXId(int Id)
        {
            try
            {

                Pais ps = ConsultarXId(Id);


                if (ps == null)
                {
                    return "Error: Pais no encontrado con el ID proporcionado.";
                }

                NatilleraDB.Paises.Remove(ps);

                NatilleraDB.SaveChanges();

                return "Pais eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el pais: " + ex.Message;
            }
        }
    }
}