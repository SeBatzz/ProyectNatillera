using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/Departamentos")]
    public class DepartamentosController : ApiController
    {

        [HttpGet]
        [Route("ConsultarXId")]
        public Departamento ConsultarXId(int Id)
        {
            ClsDepartamento departamento = new ClsDepartamento();
            return departamento.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Departamento> ConsultarTodos()
        {
            ClsDepartamento departamento = new ClsDepartamento();
            return departamento.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Departamento D)
        {
            if (D == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsDepartamento departamento = new ClsDepartamento();
            departamento.departamento = D;
            return departamento.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Departamento D)
        {
            if (D == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsDepartamento departamento = new ClsDepartamento();
            departamento.departamento = D;
            return departamento.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsDepartamento departamento = new ClsDepartamento();
            return departamento.EliminarXId(Id);
        }

    }
}