using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/EventosProveedores")]
    public class EventosProveedoresController : ApiController
    {

        [HttpGet]
        [Route("ConsultarXId")]
        public EventosProveedore ConsultarXId(int Id)
        {
            EventosProveedores eventosproveedores = new EventosProveedores();
            return eventosproveedores.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<EventosProveedore> ConsultarTodos()
        {
            EventosProveedores eventosproveedores = new EventosProveedores();
            return eventosproveedores.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] EventosProveedore Ep)
        {
            if (Ep == null)
            {
                return "Error: Los datos del cliente son nulos.";
            }
            EventosProveedores eventosproveedores = new EventosProveedores();
            eventosproveedores.eventoProveedor = Ep;
            return eventosproveedores.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] EventosProveedore Ep)
        {
            if (Ep == null)
            {
                return "Error: Los datos del cliente son nulos.";
            }
            EventosProveedores eventosproveedores = new EventosProveedores();
            eventosproveedores.eventoProveedor = Ep;
            return eventosproveedores.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            EventosProveedores eventosproveedores = new EventosProveedores();
            return eventosproveedores.EliminarXId(Id);
        }

    }
}