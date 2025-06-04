using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ProyectNatillera.Clases
{
    public class ClsMetodosPago
    {
        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public MetodosPago metodosPago { get; set; }

        public MetodosPago ConsultarXId(int Id) // Devulve un objeto Cliente
        {

            MetodosPago Cl = NatilleraDB.MetodosPagoes.FirstOrDefault(x => x.CodigoMetodoPago == Id);
            return Cl;
        }

        public List<MetodosPago> ConsultarTodos()   // Devulve una lista de Cliente
        {

            return NatilleraDB.MetodosPagoes
                .OrderBy(x => x.CodigoMetodoPago)
                .ToList();
        }

        public string Insertar()
        {
            try
            {

                if (metodosPago == null)
                {
                    return "Error: No se proporcionó un objeto metodo de pago para insertar.";
                }

                NatilleraDB.MetodosPagoes.Add(metodosPago);

                NatilleraDB.SaveChanges();
                return "Metodo de pago insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el metodo de pago: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (metodosPago == null)
            {
                return "Error: No se proporcionó un objeto metodo de pago para actualizar.";
            }

            MetodosPago cl = ConsultarXId(metodosPago.CodigoMetodoPago);

            if (cl == null)
            {
                return "Error: El ID del metodo de pago no es válido o no existe.";
            }

            try
            {

                NatilleraDB.MetodosPagoes.AddOrUpdate(metodosPago);

                NatilleraDB.SaveChanges();
                return "Metodo de pago actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el metodo de pago: " + ex.Message;
            }
        }

        public string EliminarXId(int Id)
        {
            try
            {

                MetodosPago cl = ConsultarXId(Id);


                if (cl == null)
                {
                    return "Error: Metodo de pago no encontrado con el ID proporcionado.";
                }

                NatilleraDB.MetodosPagoes.Remove(cl);

                NatilleraDB.SaveChanges();

                return "Metodo de pago eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Metodo de pago: " + ex.Message;
            }
        }

    }
}