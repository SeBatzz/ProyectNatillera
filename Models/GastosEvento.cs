//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectNatillera.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class GastosEvento
    {
        public int CodigoGasto { get; set; }
        public int CodigoEvento { get; set; }
        public string ConceptoGasto { get; set; }
        public decimal MontoGasto { get; set; }
        public System.DateTime FechaGasto { get; set; }
        public string DocumentoProveedor { get; set; }
        public string MetodoPago { get; set; }

        [JsonIgnore]
        public virtual Evento Evento { get; set; }
        [JsonIgnore]
        public virtual Proveedore Proveedore { get; set; }
    }
}
