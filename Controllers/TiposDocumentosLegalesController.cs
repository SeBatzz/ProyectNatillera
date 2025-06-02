using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/TiposDocumentosLegales")]
    public class TiposDocumentosLegalesController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXId")]
        public TiposDocumentoLegal ConsultarXId(int Id)
        {
            ClsTipoDocumentoLegal tipodocumentolegal = new ClsTipoDocumentoLegal();
            return tipodocumentolegal.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<TiposDocumentoLegal> ConsultarTodos()
        {
            ClsTipoDocumentoLegal tipodocumentolegal = new ClsTipoDocumentoLegal();
            return tipodocumentolegal.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] TiposDocumentoLegal Td)
        {
            if (Td == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsTipoDocumentoLegal tipodocumentolegal = new ClsTipoDocumentoLegal();
            tipodocumentolegal.tiposdocumentolegal = Td;
            return tipodocumentolegal.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] TiposDocumentoLegal Td)
        {
            if (Td == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsTipoDocumentoLegal tipodocumentolegal = new ClsTipoDocumentoLegal();
            tipodocumentolegal.tiposdocumentolegal = Td;
            return tipodocumentolegal.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsTipoDocumentoLegal tipodocumentolegal = new ClsTipoDocumentoLegal();
            return tipodocumentolegal.EliminarXId(Id);
        }

    }
}