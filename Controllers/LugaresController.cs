using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectNatillera.Controllers
{
    public class LugaresController : ApiController
    {
        [RoutePrefix("api/Lugares")]

        public class ClientesController : ApiController
        {

            [HttpGet]
            [Route("ConsultarXId")]
            public Lugare ConsultarXId(int Id)
            {
                ClsLugar lugar = new ClsLugar();
                return lugar.ConsultarXId(Id);
            }

            [HttpGet]
            [Route("ConsultarTodos")]
            public List<Lugare> ConsultarTodos()
            {
                ClsLugar lugar = new ClsLugar();
                return lugar.ConsultarTodos();
            }

            [HttpPost]
            [Route("Insertar")]
            public string Insertar([FromBody] Lugare lug)
            {
                if (lug == null)
                {
                    return "Error: Los datos del Lugar son nulos.";
                }
                ClsLugar lugar = new ClsLugar();
                lugar.lugar = lug;
                return lugar.Insertar();
            }

            [HttpPut]
            [Route("Actualizar")]
            public string Actualizar([FromBody] Lugare lug)
            {
                if (lug == null)
                {
                    return "Error: Los datos del Lugar son nulos.";
                }
                ClsLugar lugar = new ClsLugar();
                lugar.lugar = lug;
                return lugar.Actualizar();
            }

            [HttpDelete]
            [Route("EliminarXId")]
            public string EliminarXId(int Id)
            {
                ClsLugar lugar = new ClsLugar();
                return lugar.EliminarXId(Id);
            }
        }
    }
}