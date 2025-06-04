using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/Ciudades")]
    public class CiudadesController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXId")]
        public Ciudade ConsultarXId(int Id)
        {
            ClsCiudades ciudades = new ClsCiudades();
            return ciudades.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Ciudade> ConsultarTodos()
        {
            ClsCiudades ciudades = new ClsCiudades();
            return ciudades.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Ciudade C)
        {
            if (C == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsCiudades ciudades = new ClsCiudades();
            ciudades.ciudades = C;
            return ciudades.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Ciudade C)
        {
            if (C == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsCiudades ciudades = new ClsCiudades();
            ciudades.ciudades = C;
            return ciudades.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsCiudades ciudades = new ClsCiudades();
            return ciudades.EliminarXId(Id);
        }

    }
}