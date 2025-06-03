using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/TiposTransacciones")]
    public class TiposTransaccionesController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXId")]
        public TiposTransaccion ConsultarXId(int Id)
        {
            ClsTipoTransaccion tipostransacciones = new ClsTipoTransaccion();
            return tipostransacciones.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<TiposTransaccion> ConsultarTodos()
        {
            ClsTipoTransaccion tipostransacciones = new ClsTipoTransaccion();
            return tipostransacciones.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] TiposTransaccion Tt)
        {
            if (Tt == null)
            {
                return "Error: Los datos del cliente son nulos.";
            }
            ClsTipoTransaccion tipostransacciones = new ClsTipoTransaccion();
            tipostransacciones.tipostransaccion = Tt;
            return tipostransacciones.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] TiposTransaccion Tt)
        {
            if (Tt == null)
            {
                return "Error: Los datos del cliente son nulos.";
            }
            ClsTipoTransaccion tipostransacciones = new ClsTipoTransaccion();
            tipostransacciones.tipostransaccion = Tt;
            return tipostransacciones.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsTipoTransaccion tipostransacciones = new ClsTipoTransaccion();
            return tipostransacciones.EliminarXId(Id);
        }

    }
}