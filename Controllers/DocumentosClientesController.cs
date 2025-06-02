using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ProyectNatillera.Controllers
{

    [RoutePrefix("api/DocumentosClientes")]
    public class DocumentosClientesController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXId")]
        public DocumentosCliente ConsultarXId(int Id)
        {
            ClsDocumentosCliente documentosclientes = new ClsDocumentosCliente();
            return documentosclientes.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<DocumentosCliente> ConsultarTodos()
        {
            ClsDocumentosCliente documentosclientes = new ClsDocumentosCliente();
            return documentosclientes.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] DocumentosCliente Dc)
        {
            if (Dc == null)
            {
                return "Error: Los datos del documentosclientes son nulos.";
            }
            ClsDocumentosCliente documentosclientes = new ClsDocumentosCliente();
            documentosclientes.documentoscliente = Dc;
            return documentosclientes.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] DocumentosCliente Pt)
        {
            if (Pt == null)
            {
                return "Error: Los datos del documentosclientes son nulos.";
            }
            ClsDocumentosCliente documentosclientes = new ClsDocumentosCliente();
            documentosclientes.documentoscliente = Pt;
            return documentosclientes.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsDocumentosCliente documentosclientes = new ClsDocumentosCliente();
            return documentosclientes.EliminarXId(Id);
        }


    }
}