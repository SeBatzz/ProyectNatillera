using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Util;


namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/TransaccionesAhorros")]
    public class TransaccionesAhorrosController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXId")]
        public TransaccionesAhorro ConsultarXId(int Id)
        {
            ClsTransaccionesAhorro transaccionesahorro = new ClsTransaccionesAhorro();
            return transaccionesahorro.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<TransaccionesAhorro> ConsultarTodos()
        {
            ClsTransaccionesAhorro transaccionesahorro = new ClsTransaccionesAhorro();
            return transaccionesahorro.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] TransaccionesAhorro Ta)
        {
            if (Ta == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsTransaccionesAhorro transaccionesahorro = new ClsTransaccionesAhorro();
            transaccionesahorro.transaccion = Ta;
            return transaccionesahorro.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] TransaccionesAhorro Ta)
        {
            if (Ta == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsTransaccionesAhorro transaccionesahorro = new ClsTransaccionesAhorro();
            transaccionesahorro.transaccion = Ta;
            return transaccionesahorro.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsTransaccionesAhorro transaccionesahorro = new ClsTransaccionesAhorro();
            return transaccionesahorro.EliminarXId(Id);
        }

    }
}