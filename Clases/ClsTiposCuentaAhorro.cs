using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using ProyectNatillera.Models;


namespace ProyectNatillera.Clases
{
    public class ClsTiposCuentaAhorro
    {
        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public TiposCuentaAhorro tipoCuenta { get; set; }

        public TiposCuentaAhorro ConsultarXId(int id)
        {
            return NatilleraDB.TiposCuentaAhorro.FirstOrDefault(x => x.CodigoTipoCuenta == id);
        }

        public List<TiposCuentaAhorro> ConsultarTodos()
        {
            return NatilleraDB.TiposCuentaAhorro.OrderBy(x => x.NombreTipo).ToList();
        }

        public string Insertar()
        {
            try
            {
                if (tipoCuenta == null)
                    return "Error: No se proporcionó un objeto TipoCuentaAhorro para insertar.";

                NatilleraDB.TiposCuentaAhorro.Add(tipoCuenta);
                NatilleraDB.SaveChanges();

                return "Tipo de cuenta de ahorro insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el tipo de cuenta: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                if (tipoCuenta == null)
                    return "Error: No se proporcionó un objeto TipoCuentaAhorro para actualizar.";

                var existente = ConsultarXId(tipoCuenta.CodigoTipoCuenta);

                if (existente == null)
                    return "Error: El tipo de cuenta no existe.";

                NatilleraDB.TiposCuentaAhorro.AddOrUpdate(tipoCuenta);
                NatilleraDB.SaveChanges();

                return "Tipo de cuenta de ahorro actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el tipo de cuenta: " + ex.Message;
            }
        }

        public string EliminarXId(int id)
        {
            try
            {
                var tipo = ConsultarXId(id);

                if (tipo == null)
                    return "Error: Tipo de cuenta no encontrado.";

                NatilleraDB.TiposCuentaAhorro.Remove(tipo);
                NatilleraDB.SaveChanges();

                return "Tipo de cuenta eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el tipo de cuenta: " + ex.Message;
            }
        }

        public List<TiposCuentaAhorro> ConsultarPorEstado(bool estado)
        {
            return NatilleraDB.TiposCuentaAhorro.Where(x => x.Activo == estado).OrderBy(x => x.NombreTipo).ToList();
        }
    }
}