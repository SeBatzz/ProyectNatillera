using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/TiposServicios")]
    public class TiposServiciosController : ApiController
    {

        [HttpGet]
        [Route("ConsultarXId")]
        public TiposServicioProveedor ConsultarXId(int Id)
        {
            ClsTiposServicio tiposervicioproveedor = new ClsTiposServicio();
            return tiposervicioproveedor.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<TiposServicioProveedor> ConsultarTodos()
        {
            ClsTiposServicio tiposervicioproveedor = new ClsTiposServicio();
            return tiposervicioproveedor.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] TiposServicioProveedor tsp)
        {
            if (tsp == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsTiposServicio tiposervicioproveedor = new ClsTiposServicio();
            tiposervicioproveedor.tipoServicio = tsp;
            return tiposervicioproveedor.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] TiposServicioProveedor tsp)
        {
            if (tsp == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsTiposServicio tiposervicioproveedor = new ClsTiposServicio();
            tiposervicioproveedor.tipoServicio = tsp;
            return tiposervicioproveedor.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsTiposServicio tiposervicioproveedor = new ClsTiposServicio();
            return tiposervicioproveedor.EliminarXId(Id);
        }

    }
}