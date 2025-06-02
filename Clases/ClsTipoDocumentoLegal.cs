using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ProyectNatillera.Clases
{
    public class ClsTipoDocumentoLegal
    {
        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public TiposDocumentoLegal tiposdocumentolegal { get; set; }

        public TiposDocumentoLegal ConsultarXId(int Id)
        {

            TiposDocumentoLegal Td = NatilleraDB.TiposDocumentoLegals.FirstOrDefault(x => x.CodigoTipoDocumento == Id);
            return Td;
        }

        public List<TiposDocumentoLegal> ConsultarTodos()
        {

            return NatilleraDB.TiposDocumentoLegals
                .OrderBy(x => x.CodigoTipoDocumento)
                .ToList();
        }

        public string Insertar()
        {
            try
            {

                if (tiposdocumentolegal == null)
                {
                    return "Error: No se proporcionó un objeto Tipo de Documento Legal para insertar.";
                }

                NatilleraDB.TiposDocumentoLegals.Add(tiposdocumentolegal);

                NatilleraDB.SaveChanges();
                return "Tipo de Documento Legal insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el Tipo de Documento Legal: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (tiposdocumentolegal == null)
            {
                return "Error: No se proporcionó un objeto Tipo de Documento Legal para actualizar.";
            }

            TiposDocumentoLegal Td = ConsultarXId(tiposdocumentolegal.CodigoTipoDocumento);

            if (Td == null)
            {
                return "Error: El ID del Tipo de Documento Legal no es válido o no existe.";
            }

            try
            {

                NatilleraDB.TiposDocumentoLegals.AddOrUpdate(tiposdocumentolegal);

                NatilleraDB.SaveChanges();
                return "Tipo de Documento Legal actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el Tipo de Documento Legal: " + ex.Message;
            }
        }

        public string EliminarXId(int Id)
        {
            try
            {

                TiposDocumentoLegal Td = ConsultarXId(Id);


                if (Td == null)
                {
                    return "Error: Tipo de Documento Legal no encontrado con el ID proporcionado.";
                }

                NatilleraDB.TiposDocumentoLegals.Remove(Td);

                NatilleraDB.SaveChanges();

                return "Tipo de Documento Legal eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Tipo de Documento Legal: " + ex.Message;
            }
        }

    }
}