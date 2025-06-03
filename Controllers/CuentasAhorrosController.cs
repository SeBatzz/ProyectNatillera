using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/CuentasAhorros")]
    public class CuentasAhorrosController : ApiController
    { 

        [HttpGet]
        [Route("ConsultarXId")]
        public CuentasAhorro ConsultarXId(int Id)
        {
            ClsCuentasAhorro cuentasahorro = new ClsCuentasAhorro();
            return cuentasahorro.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<CuentasAhorro> ConsultarTodos()
        {
            ClsCuentasAhorro cuentasahorro = new ClsCuentasAhorro();
            return cuentasahorro.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] CuentasAhorro Ca)
        {
            if (Ca == null)
            {
                return "Error: Los datos del cliente son nulos.";
            }
            ClsCuentasAhorro cuentasahorro = new ClsCuentasAhorro();
            cuentasahorro.cuentaAhorro = Ca;
            return cuentasahorro.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] CuentasAhorro Ca)
        {
            if (Ca == null)
            {
                return "Error: Los datos del cliente son nulos.";
            }
            ClsCuentasAhorro cuentasahorro = new ClsCuentasAhorro();
            cuentasahorro.cuentaAhorro = Ca;
            return cuentasahorro.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsCuentasAhorro cuentasahorro = new ClsCuentasAhorro();
            return cuentasahorro.EliminarXId(Id);
        }

    }
}