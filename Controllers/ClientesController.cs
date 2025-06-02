using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectNatillera.Models;
using ProyectNatillera.Clases;
using System.Web.Http;

namespace ProyectNatillera.Controllers
{
    [RoutePrefix("api/Clientes")]
    
    public class ClientesController : ApiController
    {

        [HttpGet]
        [Route("ConsultarXId")]
        public Cliente ConsultarXId(string Id)
        {
            ClsCliente cliente = new ClsCliente();
            return cliente.ConsultarXId(Id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Cliente> ConsultarTodos()
        {
            ClsCliente cliente = new ClsCliente();
            return cliente.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Cliente cli)
        {
            if (cli == null)
            {
                return "Error: Los datos del cliente son nulos.";
            }
            ClsCliente cliente = new ClsCliente();
            cliente.cliente = cli;
            return cliente.Insertar();
        }
        
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Cliente cli)
        {
            if (cli == null)
            {
                return "Error: Los datos del cliente son nulos.";
            }
            ClsCliente cliente = new ClsCliente();
            cliente.cliente = cli;
            return cliente.Actualizar();
        }

        [HttpDelete]
        [Route("EliminarXId")] 
        public string EliminarXId(string Id)
        {
            ClsCliente cliente = new ClsCliente();
            return cliente.EliminarXId(Id);
        }

        // Not Implemted 

     


        [HttpGet]
        [Route("ConsultarActivos")]
        public List<Cliente> ConsultarActivos()
        {
            ClsCliente cliente = new ClsCliente();
            return cliente.ConsultarPorEstado(true); // Asumiendo un método en ClsCliente
        }

        [HttpGet]
        [Route("ConsultarXCiudad")]
        public List<Cliente> ConsultarXCiudad(int codigoCiudad)
        {
            ClsCliente cliente = new ClsCliente();
            return cliente.ConsultarPorCiudad(codigoCiudad); // Asumiendo un método en ClsCliente
        }

        [HttpGet]
        [Route("ConsultarXEmail")]
        public Cliente ConsultarXEmail(string email)
        {
            ClsCliente cliente = new ClsCliente();
            return cliente.ConsultarPorEmail(email); // Asumiendo un método en ClsCliente
        }

        [HttpPut]
        [Route("CambiarEstado")]
        public string CambiarEstado(string documentoCliente, bool activo)
        {
            ClsCliente cliente = new ClsCliente();
            return cliente.CambiarEstado(documentoCliente, activo); // Asumiendo un método en ClsCliente
        }

    }


}