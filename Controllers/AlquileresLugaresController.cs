using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/AlquileresLugares")]
    public class AlquileresLugaresController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXId")]
        public AlquileresLugar ConsultarXId(int Id)
        {
            ClsAlquileresLugar alquilereslugar = new ClsAlquileresLugar();
            return alquilereslugar.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<AlquileresLugar> ConsultarTodos()
        {
            ClsAlquileresLugar alquilereslugar = new ClsAlquileresLugar();
            return alquilereslugar.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] AlquileresLugar Al)
        {
            if (Al == null)
            {
                return "Error: Los datos del cliente son nulos.";
            }
            ClsAlquileresLugar alquilereslugar = new ClsAlquileresLugar();
            alquilereslugar.alquileresLugar = Al;
            return alquilereslugar.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] AlquileresLugar Al)
        {
            if (Al == null)
            {
                return "Error: Los datos del cliente son nulos.";
            }
            ClsAlquileresLugar alquilereslugar = new ClsAlquileresLugar();
            alquilereslugar.alquileresLugar = Al;
            return alquilereslugar.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsAlquileresLugar alquilereslugar = new ClsAlquileresLugar();
            return alquilereslugar.EliminarXId(Id);
        }

    }
}