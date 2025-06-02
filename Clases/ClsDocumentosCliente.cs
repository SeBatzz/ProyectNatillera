using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ProyectNatillera.Clases
{
    public class ClsDocumentosCliente
    {

        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public DocumentosCliente documentoscliente { get; set; }

        public DocumentosCliente ConsultarXId(int Id)
        {

            DocumentosCliente Dc = NatilleraDB.DocumentosClientes.FirstOrDefault(x => x.CodigoDocumento == Id);
            return Dc;
        }

        public List<DocumentosCliente> ConsultarTodos()
        {

            return NatilleraDB.DocumentosClientes
                .OrderBy(x => x.CodigoDocumento)
                .ToList();
        }

        public string Insertar()
        {
            try
            {

                if (documentoscliente == null)
                {
                    return "Error: No se proporcionó un objeto Documento de Cliente para insertar.";
                }

                NatilleraDB.DocumentosClientes.Add(documentoscliente);

                NatilleraDB.SaveChanges();
                return "Documento de Cliente insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el Documento de Cliente: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (documentoscliente == null)
            {
                return "Error: No se proporcionó un objeto Documento de Cliente para actualizar.";
            }

            DocumentosCliente Dc = ConsultarXId(documentoscliente.CodigoDocumento);

            if (Dc == null)
            {
                return "Error: El ID del Documento de Cliente no es válido o no existe.";
            }

            try
            {

                NatilleraDB.DocumentosClientes.AddOrUpdate(documentoscliente);

                NatilleraDB.SaveChanges();
                return "Documento de Cliente actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el Documento de Cliente: " + ex.Message;
            }
        }

        public string EliminarXId(int Id)
        {
            try
            {

                DocumentosCliente Dc = ConsultarXId(Id);


                if (Dc == null)
                {
                    return "Error: Documento de Cliente no encontrado con el ID proporcionado.";
                }

                NatilleraDB.DocumentosClientes.Remove(Dc);

                NatilleraDB.SaveChanges();

                return "Documento de Cliente eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Documento de Cliente: " + ex.Message;
            }
        }
    }
}