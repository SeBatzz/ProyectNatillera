using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/Participaciones")]
    public class ParticipacionEventoController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXId")]
        public ParticipacionEvento ConsultarXId(int id)
        {
            ClsParticipacionEvento clsParticipacion = new ClsParticipacionEvento();
            return clsParticipacion.ConsultarXId(id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<ParticipacionEvento> ConsultarTodos()
        {
            ClsParticipacionEvento clsParticipacion = new ClsParticipacionEvento();
            return clsParticipacion.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] ParticipacionEvento participacion)
        {
            if (participacion == null)
            {
                return "Error: Los datos de participación son nulos.";
            }

            ClsParticipacionEvento clsParticipacion = new ClsParticipacionEvento();
            clsParticipacion.participacion = participacion;
            return clsParticipacion.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] ParticipacionEvento participacion)
        {
            if (participacion == null)
            {
                return "Error: Los datos de participación son nulos.";
            }

            ClsParticipacionEvento clsParticipacion = new ClsParticipacionEvento();
            clsParticipacion.participacion = participacion;
            return clsParticipacion.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id)
        {
            ClsParticipacionEvento clsParticipacion = new ClsParticipacionEvento();
            return clsParticipacion.EliminarXId(id);
        }
    }
}