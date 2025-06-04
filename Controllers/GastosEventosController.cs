using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
        

namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/GastosEventos")]
    public class GastosEventosController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXId")]
        public GastosEvento ConsultarXId(int Id)
        {
            ClsGastosEvento gastosevento = new ClsGastosEvento();
            return gastosevento.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<GastosEvento> ConsultarTodos()
        {
            ClsGastosEvento gastosevento = new ClsGastosEvento();
            return gastosevento.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] GastosEvento Ge)
        {
            if (Ge == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsGastosEvento gastosevento = new ClsGastosEvento();
            gastosevento.gastosEvento = Ge;
            return gastosevento.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] GastosEvento Ga)
        {
            if (Ga == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsGastosEvento gastosevento = new ClsGastosEvento();
            gastosevento.gastosEvento = Ga;
            return gastosevento.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsGastosEvento gastosevento = new ClsGastosEvento();
            return gastosevento.EliminarXId(Id);
        }


    }
}