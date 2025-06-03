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

    [RoutePrefix("api/TiposCuentasAhorros")]
    public class TiposCuentasAhorrosController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXId")]
        public TiposCuentaAhorro ConsultarXId(int Id)
        {
            ClsTiposCuentaAhorro tiposcuentaahorros = new ClsTiposCuentaAhorro();
            return tiposcuentaahorros.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<TiposCuentaAhorro> ConsultarTodos()
        {
            ClsTiposCuentaAhorro tiposcuentaahorros = new ClsTiposCuentaAhorro();
            return tiposcuentaahorros.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] TiposCuentaAhorro Tca)
        {
            if (Tca == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsTiposCuentaAhorro tiposcuentaahorros = new ClsTiposCuentaAhorro();
            tiposcuentaahorros.tipoCuenta = Tca;
            return tiposcuentaahorros.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] TiposCuentaAhorro Tca)
        {
            if (Tca == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsTiposCuentaAhorro tiposcuentaahorros = new ClsTiposCuentaAhorro();
            tiposcuentaahorros.tipoCuenta = Tca;
            return tiposcuentaahorros.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsTiposCuentaAhorro tiposcuentaahorros = new ClsTiposCuentaAhorro();
            return tiposcuentaahorros.EliminarXId(Id);
        }
    }
}