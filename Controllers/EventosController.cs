using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;  
using System.Web;
using System.Web.Http;


namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/Eventos")]
    public class EventosController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXId")]
        public Evento ConsultarXId(int Id)
        {
            ClsEvento evento = new ClsEvento();
            return evento.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Evento> ConsultarTodos()
        {
            ClsEvento evento = new ClsEvento();
            return evento.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Evento E)
        {
            if (E == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsEvento evento = new ClsEvento();
            evento.evento = E;
            return evento.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Evento e)
        {
            if (e == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsEvento evento = new ClsEvento();
            evento.evento = e;
            return evento.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsEvento evento = new ClsEvento();
            return evento.EliminarXId(Id);
        }

    }
}