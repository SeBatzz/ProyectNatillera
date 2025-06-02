using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/PagosPrestamos")]
    public class PagoPrestamosController : ApiController
    {

        [HttpGet]
        [Route("ConsultarXId")]
        public PagosPrestamo ConsultarXId(int Id)
        {
            ClsPagosPrestamo pagoprestamo = new ClsPagosPrestamo();
            return pagoprestamo.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<PagosPrestamo> ConsultarTodos()
        {
            ClsPagosPrestamo pagoprestamo = new ClsPagosPrestamo();
            return pagoprestamo.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] PagosPrestamo Pp)
        {
            if (Pp == null)
            {
                return "Error: Los datos del Pago del Prestamo son nulos.";
            }
            ClsPagosPrestamo pagoprestamo = new ClsPagosPrestamo();
            pagoprestamo.pagosprestamo = Pp;
            return pagoprestamo.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] PagosPrestamo Pp)
        {
            if (Pp == null)
            {
                return "Error: Los datos del Pago del Prestamo son nulos.";
            }
            ClsPagosPrestamo pagoprestamo = new ClsPagosPrestamo();
            pagoprestamo.pagosprestamo = Pp;
            return pagoprestamo.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsPagosPrestamo pagoprestamo = new ClsPagosPrestamo();
            return pagoprestamo.EliminarXId(Id);
        }


    }
}