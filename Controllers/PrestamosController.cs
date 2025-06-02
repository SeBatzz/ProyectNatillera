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
            ClsPrestamos prestamo = new ClsPrestamos();
            return prestamo.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Prestamo> ConsultarTodos()
        {
            ClsPrestamos prestamo = new ClsPrestamos();
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
            ClsPrestamos prestamo = new ClsPrestamos();
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
            ClsPrestamos prestamo = new ClsPrestamos();
            prestamo.prestamo = Pt;
            return prestamo.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsPrestamos prestamo = new ClsPrestamos();
            return prestamo.EliminarXId(Id);
        }


    }
}