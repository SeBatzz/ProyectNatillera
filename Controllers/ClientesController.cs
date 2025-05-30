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
        [Route("ConsultarXDocumento")]
        public Cliente ConsultarXDocumento(string Documento)
        {
            ClsCliente cliente = new ClsCliente();
            return cliente.ConsultarXDocumento(Documento);
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
            ClsCliente nuevoCliente = new ClsCliente();
            nuevoCliente.cliente = cli;
            return nuevoCliente.Insertar();
        }
        
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Cliente cli)
        {
            if (cli == null)
            {
                return "Error: Los datos del cliente son nulos.";
            }
            ClsCliente clienteAActualizar = new ClsCliente();
            clienteAActualizar.cliente = cli;
            return clienteAActualizar.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")] 
        public string Eliminar(string documento)
        {
            ClsCliente cliente = new ClsCliente();
            return cliente.EliminarPorDocumento(documento);
        }

        //  Posibles funcionalidades adicionales 

     


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