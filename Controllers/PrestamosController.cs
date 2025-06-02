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
    public class PrestamosController : ApiController
    {

        [HttpGet]
        [Route("ConsultarXId")]
        public Prestamo ConsultarXId(int Id)
        {
            ClsPrestamo prestamo = new ClsPrestamo();
            return prestamo.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Prestamo> ConsultarTodos()
        {
            ClsPrestamo prestamo = new ClsPrestamo();
            return prestamo.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Prestamo Pt)
        {
            if (Pt == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsPrestamo prestamo = new ClsPrestamo();
            prestamo.prestamo = Pt;
            return prestamo.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Prestamo Pt)
        {
            if (Pt == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsPrestamo prestamo = new ClsPrestamo();
            prestamo.prestamo = Pt;
            return prestamo.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsPrestamo prestamo = new ClsPrestamo();
            return prestamo.EliminarXId(Id);
        }


    }
}