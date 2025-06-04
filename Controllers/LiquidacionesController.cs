using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/Liquidaciones")]
    public class LiquidacionesController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXId")]
        public Liquidacione ConsultarXId(int Id)
        {
            ClsLiquidaciones liquidaciones = new ClsLiquidaciones();
            return liquidaciones.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Liquidacione> ConsultarTodos()
        {
            ClsLiquidaciones liquidaciones = new ClsLiquidaciones();
            return liquidaciones.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Liquidacione L)
        {
            if (L == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsLiquidaciones liquidaciones = new ClsLiquidaciones();
            liquidaciones.liquidaciones = L;
            return liquidaciones.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Liquidacione L)
        {
            if (L == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsLiquidaciones liquidaciones = new ClsLiquidaciones();
            liquidaciones.liquidaciones = L;
            return liquidaciones.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsLiquidaciones liquidaciones = new ClsLiquidaciones();
            return liquidaciones.EliminarXId(Id);
        }

    }
}