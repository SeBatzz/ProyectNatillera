using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectNatillera.Models;

namespace ProyectNatillera.Clases
{
    public class ClsCliente
    {
        public NatilleraDBEntities NatilleraDB = new NatilleraDBEntities();
        public Cliente Cliente { get; set; }

        public Cliente ConsultarXDocumento(string Documento)
        {

            Cliente Cl = NatilleraDB.Clientes.FirstOrDefault(e => e.DocumentoCliente == Documento);
            return Cl;
        }
    }
}