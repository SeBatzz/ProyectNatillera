using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using ProyectNatillera.Models;

namespace ProyectNatillera.Clases
{
    public class ClsCuentasAhorro
    {

        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public CuentasAhorro cuentaAhorro { get; set; }

        // Consultar por ID
        public CuentasAhorro ConsultarXId(int Id)
        {
            CuentasAhorro Ca = NatilleraDB.CuentasAhorroes.FirstOrDefault(x => x.CodigoCuenta == Id);
            return Ca;
        }

        // Consultar todas las cuentas
        public List<CuentasAhorro> ConsultarTodos()
        {
            return NatilleraDB.CuentasAhorroes.OrderBy(c => c.CodigoCuenta).ToList();
        }

        // Insertar una nueva cuenta
        public string Insertar()
        {
            try
            {
                if (cuentaAhorro == null)
                {
                    return "Error: No se proporcionó una cuenta para insertar.";
                }

                NatilleraDB.CuentasAhorroes.Add(cuentaAhorro);
                NatilleraDB.SaveChanges();

                return "Cuenta de ahorro insertada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar la cuenta de ahorro: " + ex.Message;
            }
        }

        // Actualizar cuenta
        public string Actualizar()
        {
            if (cuentaAhorro == null)
            {
                return "Error: No se proporcionó una cuenta para actualizar.";
            }

            CuentasAhorro cuentaExistente = ConsultarXId(cuentaAhorro.CodigoCuenta);

            if (cuentaExistente == null)
            {
                return "Error: La cuenta no existe.";
            }

            try
            {
                NatilleraDB.CuentasAhorroes.AddOrUpdate(cuentaAhorro);
                NatilleraDB.SaveChanges();

                return "Cuenta de ahorro actualizada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la cuenta de ahorro: " + ex.Message;
            }
        }

        // Eliminar cuenta
        public string EliminarXId(int codigoCuenta)
        {
            try
            {
                var cuenta = ConsultarXId(codigoCuenta);

                if (cuenta == null)
                {
                    return "Error: Cuenta no encontrada.";
                }

                NatilleraDB.CuentasAhorroes.Remove(cuenta);
                NatilleraDB.SaveChanges();

                return "Cuenta de ahorro eliminada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la cuenta de ahorro: " + ex.Message;
            }
        }

        // Consultar por estado (activa/inactiva)
        public List<CuentasAhorro> ConsultarPorEstado(string estado)
        {
            return NatilleraDB.CuentasAhorroes.Where(c => c.Estado == estado).OrderBy(c => c.FechaApertura).ToList();
        }

        // Consultar por cliente
        public List<CuentasAhorro> ConsultarPorCliente(string documentoCliente)
        {
            return NatilleraDB.CuentasAhorroes.Where(c => c.DocumentoCliente == documentoCliente).OrderByDescending(c => c.FechaApertura).ToList();
        }
    }
}