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
    [RoutePrefix("api/Proveedores")]
    public class ProveedorController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXId")]
        public Proveedore ConsultarXId(string Id)
        {
            ClsProveedor prov = new ClsProveedor();
            return prov.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Proveedore> ConsultarTodos()
        {
            ClsProveedor prov = new ClsProveedor();
            return prov.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Proveedore prov)
        {
            if (prov == null)
            {
                return "Error: Los datos del proveedor son nulos.";
            }
            ClsProveedor proveedor = new ClsProveedor();
            proveedor.proveedor = prov;
            return proveedor.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Proveedore prov)
        {
            if (prov == null)
            {
                return "Error: Los datos del proveedor son nulos";
            }
            ClsProveedor proveedor = new ClsProveedor();
            proveedor.proveedor = prov;
            return proveedor.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(string Id)
        {
            ClsProveedor prov = new ClsProveedor();
            return prov.EliminarXId(Id);
        }
    }
}