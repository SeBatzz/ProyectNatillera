using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ProyectNatillera.Clases
{
    public class ClsDepartamento
    {

        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public Departamento departamento { get; set; }

        public Departamento ConsultarXId(int Id) 
        {

            Departamento Cl = NatilleraDB.Departamentos.FirstOrDefault(x => x.CodigoDepartamento == Id);
            return Cl;
        }

        public List<Departamento> ConsultarTodos()  
        {

            return NatilleraDB.Departamentos
                .OrderBy(x => x.CodigoDepartamento)
                .ToList();
        }

        public string Insertar()
        {
            try
            {

                if (departamento == null)
                {
                    return "Error: No se proporcionó un objeto departamento para insertar.";
                }

                NatilleraDB.Departamentos.Add(departamento);

                NatilleraDB.SaveChanges();
                return "Departamento insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el departamento: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (departamento == null)
            {
                return "Error: No se proporcionó un objeto departamento para actualizar.";
            }

            Departamento cl = ConsultarXId(departamento.CodigoDepartamento);

            if (cl == null)
            {
                return "Error: El ID del departamento no es válido o no existe.";
            }

            try
            {
                NatilleraDB.Departamentos.AddOrUpdate(departamento);

                NatilleraDB.SaveChanges();
                return "Departamento actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el departamento: " + ex.Message;
            }
        }

        public string EliminarXId(int Id)
        {
            try
            {

                Departamento cl = ConsultarXId(Id);


                if (cl == null)
                {
                    return "Error: Departamento no encontrado con el ID proporcionado.";
                }

                NatilleraDB.Departamentos.Remove(cl);

                NatilleraDB.SaveChanges();

                return "Departamento eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el departamento: " + ex.Message;
            }
        }

    }
}