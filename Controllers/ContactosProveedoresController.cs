using ProyectNatillera.Clases;
using ProyectNatillera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/ContactosProveedores")]
    public class ContactosProveedoresController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXId")]
        public ContactosProveedor ConsultarXId(int Id)
        {
            ClsContactosProveedor contactosproveedor = new ClsContactosProveedor();
            return contactosproveedor.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<ContactosProveedor> ConsultarTodos()
        {
            ClsContactosProveedor contactosproveedor = new ClsContactosProveedor();
            return contactosproveedor.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] ContactosProveedor Cp)
        {
            if (Cp == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsContactosProveedor contactosproveedor = new ClsContactosProveedor();
            contactosproveedor.contactosProveedor = Cp;
            return contactosproveedor.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] ContactosProveedor Cp)
        {
            if (Cp == null)
            {
                return "Error: Los datos del Prestamo son nulos.";
            }
            ClsContactosProveedor contactosproveedor = new ClsContactosProveedor();
            contactosproveedor.contactosProveedor = Cp;
            return contactosproveedor.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int Id)
        {
            ClsContactosProveedor contactosproveedor = new ClsContactosProveedor();
            return contactosproveedor.EliminarXId(Id);
        }

    }
}