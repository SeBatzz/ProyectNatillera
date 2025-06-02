using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ProyectNatillera.Clases
{
    public class ClsPrestamo
    {

        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public Prestamo prestamo { get; set; }

        public Prestamo ConsultarXId(int Id)
        {

            Prestamo Pt = NatilleraDB.Prestamos.FirstOrDefault(x => x.CodigoPrestamo == Id);
            return Pt;
        }

        public List<Prestamo> ConsultarTodos()
        {

            return NatilleraDB.Prestamos
                .OrderBy(x => x.CodigoPrestamo)
                .ToList();
        }

        public string Insertar()
        {
            try
            {

                if (prestamo == null)
                {
                    return "Error: No se proporcionó un objeto Prestamo para insertar.";
                }

                NatilleraDB.Prestamos.Add(prestamo);

                NatilleraDB.SaveChanges();
                return "Prestamo insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el Prestamo: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (prestamo == null)
            {
                return "Error: No se proporcionó un objeto Prestamo para actualizar.";
            }

            Prestamo Pt = ConsultarXId(prestamo.CodigoPrestamo);

            if (Pt == null)
            {
                return "Error: El ID del Prestamo no es válido o no existe.";
            }

            try
            {

                NatilleraDB.Prestamos.AddOrUpdate(prestamo);

                NatilleraDB.SaveChanges();
                return "Prestamo actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el Prestamo: " + ex.Message;
            }
        }

        public string EliminarXId(int Id)
        {
            try
            {

                Prestamo Pt = ConsultarXId(Id);


                if (Pt == null)
                {
                    return "Error: Prestamo no encontrado con el ID proporcionado.";
                }

                NatilleraDB.Prestamos.Remove(Pt);

                NatilleraDB.SaveChanges();

                return "Prestamo eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Prestamo: " + ex.Message;
            }
        }

    }
}