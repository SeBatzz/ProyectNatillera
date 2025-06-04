using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/Prestamos")]
    public class MetodosPagosController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXId")]
        public MetodosPago ConsultarXId(int Id)
        {
            ClsMetodosPago metodospagos = new ClsMetodosPago();
            return metodospagos.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<MetodosPago> ConsultarTodos()
        {
            ClsMetodosPago metodospagos = new ClsMetodosPago();
            return metodospagos.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] MetodosPago Mp)
        {
            if (Mp == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsMetodosPago metodospagos = new ClsMetodosPago();
            metodospagos.metodosPago = Mp;
            return metodospagos.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] MetodosPago Mp)
        {
            if (Mp == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsMetodosPago metodospagos = new ClsMetodosPago();
            metodospagos.metodosPago = Mp;
            return metodospagos.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsMetodosPago metodospagos = new ClsMetodosPago();
            return metodospagos.EliminarXId(Id);
        }

    }
}