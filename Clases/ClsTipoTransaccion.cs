using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ProyectNatillera.Clases
{
    public class ClsTipoTransaccion
    {
        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public TiposTransaccion tipostransaccion { get; set; }

        public TiposTransaccion ConsultarXId(int Id) 
        {

            TiposTransaccion Tt = NatilleraDB.TiposTransaccions.FirstOrDefault(x => x.CodigoTipoTransaccion == Id);
            return Tt;
        }

        public List<TiposTransaccion> ConsultarTodos()   
        {

            return NatilleraDB.TiposTransaccions
                .OrderBy(x => x.CodigoTipoTransaccion)
                .ToList();
        }

        public string Insertar()
        {
            try
            {

                if (tipostransaccion == null)
                {
                    return "Error: No se proporcionó un objeto Cliente para insertar.";
                }

                NatilleraDB.TiposTransaccions.Add(tipostransaccion);

                NatilleraDB.SaveChanges();
                return "Cliente insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el cliente: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (tipostransaccion == null)
            {
                return "Error: No se proporcionó un objeto Cliente para actualizar.";
            }

            TiposTransaccion Tt = ConsultarXId(tipostransaccion.CodigoTipoTransaccion);

            if (Tt == null)
            {
                return "Error: El ID del Prestamo no es válido o no existe.";
            }

            try
            {

                NatilleraDB.TiposTransaccions.AddOrUpdate(tipostransaccion);

                NatilleraDB.SaveChanges();
                return "Cliente actualizado correctamente.";
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

                TiposTransaccion Tt = ConsultarXId(Id);

                if (Tt == null)
                {
                    return "Error: Cliente no encontrado con el ID proporcionado.";
                }

                NatilleraDB.TiposTransaccions.Remove(Tt);

                NatilleraDB.SaveChanges();

                return "Cliente eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el cliente: " + ex.Message;
            }
        }
    }
}