using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectNatillera.Models;
using ProyectNatillera.Clases;
using System.Web.Http;

namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/Clientes")]
    
    public class ClientesController : ApiController
    {

        [HttpGet]
        [Route("ConsultarXDocumento")]
        public Cliente ConsultarXDocumento(string Documento)
        {
            ClsCliente cliente = new ClsCliente();
            return cliente.ConsultarXDocumento(Documento);
        }
    }
}