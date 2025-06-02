using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using ProyectNatillera.Models;

namespace ProyectNatillera.Clases
{
    public class ClsCliente
    {
        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public Cliente cliente { get; set; }

        public Cliente ConsultarXId(string Id) // Devulve un objeto Cliente
        {

            Cliente Cl = NatilleraDB.Clientes.FirstOrDefault(x => x.DocumentoCliente == Id);
            return Cl;
        }

        public List<Cliente> ConsultarTodos()   // Devulve una lista de Cliente
        {
            
            return NatilleraDB.Clientes
                .OrderBy(x => x.DocumentoCliente)
                .ToList();
        }

        public string Insertar()
        {
            try
            {
                
                if (cliente == null)
                {
                    return "Error: No se proporcionó un objeto Cliente para insertar.";
                }

                NatilleraDB.Clientes.Add(cliente);

                NatilleraDB.SaveChanges();
                return "Cliente insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el cliente: " + ex.Message;
            }
        }

        public string Actualizar()
        {

            if (cliente == null)
            {
                return "Error: No se proporcionó un objeto Cliente para actualizar.";
            }

            Cliente cl = ConsultarXId(cliente.DocumentoCliente);

            if (cl == null)
            {
                return "Error: El ID del Prestamo no es válido o no existe.";
            }

            try
            {

                NatilleraDB.Clientes.AddOrUpdate(cliente);

                NatilleraDB.SaveChanges();
                return "Cliente actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el cliente: " + ex.Message;
            }
        }

        public string EliminarXId(string Id)
        {
            try
            {

                Cliente cl = ConsultarXId(Id);


                if (cl == null)
                {
                    return "Error: Cliente no encontrado con el ID proporcionado.";
                }

                NatilleraDB.Clientes.Remove(cl);

                NatilleraDB.SaveChanges();

                return "Cliente eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el cliente: " + ex.Message;
            }
        }

        // Not Implemted 

        public List<Cliente> ConsultarPorEstado(bool estado)
        {
            return NatilleraDB.Clientes
                .Where(c => c.Activo == estado)
                .OrderBy(c => c.Nombres)
                .ToList();
        }
        public List<Cliente> ConsultarPorCiudad(int codigoCiudad)
        {
            return NatilleraDB.Clientes
                .Where(c => c.CodigoCiudad == codigoCiudad)
                .OrderBy(c => c.PrimerApellido)
                .ThenBy(c => c.Nombres)
                .ToList();
        }

        public Cliente ConsultarPorEmail(string email)
        {
            return NatilleraDB.Clientes.FirstOrDefault(c => c.Email == email);
        }

        public string CambiarEstado(string documentoCliente, bool nuevoEstado)
        {
            try
            {

                Cliente cl = ConsultarXId(documentoCliente);

                if (cl == null)
                {
                    return "Error: Cliente no encontrado con el ID proporcionado.";
                }

                cl.Activo = nuevoEstado;
                NatilleraDB.Clientes.AddOrUpdate(cl);
                NatilleraDB.SaveChanges();

                return "Estado del cliente actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al cambiar el estado del cliente: " + ex.Message;
            }
        }
    }
}