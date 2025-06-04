using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ProyectNatillera.Clases
{
    public class ClsLiquidaciones
    {
        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public Liquidacione liquidaciones { get; set; }

        public Liquidacione ConsultarXId(int Id) // Devulve un objeto Cliente
        {

            Liquidacione Cl = NatilleraDB.Liquidaciones.FirstOrDefault(x => x.CodigoLiquidacion == Id);
            return Cl;
        }

        public List<Liquidacione> ConsultarTodos()   // Devulve una lista de Cliente
        {

            return NatilleraDB.Liquidaciones
                .OrderBy(x => x.CodigoLiquidacion)
                .ToList();
        }

        public string Insertar()
        {
            try
            {

                if (liquidaciones == null)
                {
                    return "Error: No se proporcionó un objeto liquidación para insertar.";
                }

                NatilleraDB.Liquidaciones.Add(liquidaciones);

                NatilleraDB.SaveChanges();
                return "Liquidación insertada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar la liquidación: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (liquidaciones == null)
            {
                return "Error: No se proporcionó un objeto liquidación para actualizar.";
            }

            Liquidacione cl = ConsultarXId(liquidaciones.CodigoLiquidacion);

            if (cl == null)
            {
                return "Error: El ID de la liquidación no es válido o no existe.";
            }

            try
            {

                NatilleraDB.Liquidaciones.AddOrUpdate(liquidaciones);

                NatilleraDB.SaveChanges();
                return "Liquidación actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la liquidación: " + ex.Message;
            }
        }

        public string EliminarXId(int Id)
        {
            try
            {

                Liquidacione cl = ConsultarXId(Id);


                if (cl == null)
                {
                    return "Error: Cliente no encontrado con el ID proporcionado.";
                }

                NatilleraDB.Liquidaciones.Remove(cl);

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