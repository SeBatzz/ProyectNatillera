using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using ProyectNatillera.Models;

namespace ProyectNatillera.Clases
{
    public class ClsTransaccionesAhorro
    {
        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public TransaccionesAhorro transaccion { get; set; }

        public TransaccionesAhorro ConsultarXId(int id)
        {
            return NatilleraDB.TransaccionesAhorro.FirstOrDefault(x => x.CodigoTransaccion == id);
        }

        public List<TransaccionesAhorro> ConsultarTodos()
        {
            return NatilleraDB.TransaccionesAhorro.OrderBy(x => x.FechaTransaccion).ToList();
        }

        public string Insertar()
        {
            try
            {
                if (transaccion == null)
                    return "Error: No se proporcionó una transacción para insertar.";

                NatilleraDB.TransaccionesAhorro.Add(transaccion);
                NatilleraDB.SaveChanges();
                return "Transacción insertada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar la transacción: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                if (transaccion == null)
                    return "Error: No se proporcionó una transacción para actualizar.";

                TransaccionesAhorro tr = ConsultarXId(transaccion.CodigoTransaccion);

                if (tr == null)
                    return "Error: La transacción no existe.";

                NatilleraDB.TransaccionesAhorro.AddOrUpdate(transaccion);
                NatilleraDB.SaveChanges();
                return "Transacción actualizada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la transacción: " + ex.Message;
            }
        }

        public string EliminarXId(int id)
        {
            try
            {
                TransaccionesAhorro tr = ConsultarXId(id);

                if (tr == null)
                    return "Error: No se encontró la transacción con el ID proporcionado.";

                NatilleraDB.TransaccionesAhorro.Remove(tr);
                NatilleraDB.SaveChanges();

                return "Transacción eliminada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la transacción: " + ex.Message;
            }
        }

        //consultar transacciones por cuenta
        public List<TransaccionesAhorro> ConsultarPorCuenta(int codigoCuenta)
        {
            return NatilleraDB.TransaccionesAhorro.Where(x => x.CodigoCuenta == codigoCuenta).OrderByDescending(x => x.FechaTransaccion).ToList();
        }
    }
}