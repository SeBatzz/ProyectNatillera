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
    
        [RoutePrefix("api/Paises")]

        public class PaisController : ApiController
        {

            [HttpGet]
            [Route("ConsultarXId")]
            public Pais ConsultarXId(int Id)
            {
                ClsPais pais = new ClsPais();
                return pais.ConsultarXId(Id);
            }

            [HttpGet]
            [Route("ConsultarTodos")]
            public List<Pais> ConsultarTodos()
            {
                ClsPais pais = new ClsPais();
                return pais.ConsultarTodos();
            }

            [HttpPost]
            [Route("Insertar")]
            public string Insertar([FromBody] Pais ps)
            {
                if (ps == null)
                {
                    return "Error: Los datos del Pais son nulos.";
                }
                ClsPais pais = new ClsPais();
                pais.pais = ps;
                return pais.Insertar();
            }

            [HttpPut]
            [Route("Actualizar")]
            public string Actualizar([FromBody] Pais ps)
            {
                if (ps == null)
                {
                    return "Error: Los datos del Pais son nulos.";
                }
                ClsPais pais = new ClsPais();
                pais.pais = ps;
                return pais.Actualizar();
            }

            [HttpDelete]
            [Route("EliminarXId")]
            public string EliminarXId(int Id)
            {
                ClsPais pais = new ClsPais();
                return pais.EliminarXId(Id);
            }
        }
    }
