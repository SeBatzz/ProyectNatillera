using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ProyectNatillera.Clases
{
    public class ClsPagosPrestamo
    {

        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public PagosPrestamo pagosprestamo { get; set; }

        public PagosPrestamo ConsultarXId(int Id)
        {

            PagosPrestamo Pp = NatilleraDB.PagosPrestamoes.FirstOrDefault(x => x.CodigoPago == Id);
            return Pp;
        }

        public List<PagosPrestamo> ConsultarTodos()
        {

            return NatilleraDB.PagosPrestamoes
                .OrderBy(x => x.CodigoPrestamo)
                .ToList();
        }

        public string Insertar()
        {
            try
            {

                if (pagosprestamo == null)
                {
                    return "Error: No se proporcionó un objeto Pago del Prestamo para insertar.";
                }

                NatilleraDB.PagosPrestamoes.Add(pagosprestamo);

                NatilleraDB.SaveChanges();
                return "Pago del Prestamo insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el Pago del Prestamo: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (pagosprestamo == null)
            {
                return "Error: No se proporcionó un objeto Pago del Prestamo para actualizar.";
            }

            PagosPrestamo Pp = ConsultarXId(pagosprestamo.CodigoPago);

            if (Pp == null)
            {
                return "Error: El ID del Pago del Prestamo no es válido o no existe.";
            }

            try
            {

                NatilleraDB.PagosPrestamoes.AddOrUpdate(pagosprestamo);

                NatilleraDB.SaveChanges();
                return "Pago del Prestamo actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el Pago del Prestamo: " + ex.Message;
            }
        }

        public string EliminarXId(int Id)
        {
            try
            {

                PagosPrestamo Pp = ConsultarXId(Id);


                if (Pp == null)
                {
                    return "Error: Pago del Prestamo no encontrado con el ID proporcionado.";
                }

                NatilleraDB.PagosPrestamoes.Remove(Pp);

                NatilleraDB.SaveChanges();

                return "Pago del Prestamo eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Pago del Prestamo: " + ex.Message;
            }
        }

    }
}