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
    
    public partial class TiposCuentaAhorro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TiposCuentaAhorro()
        {
            this.CuentasAhorroes = new HashSet<CuentasAhorro>();
        }
    
        public int CodigoTipoCuenta { get; set; }
        public string NombreTipo { get; set; }
        public bool Activo { get; set; }
        [JsonIgnore]

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentasAhorro> CuentasAhorroes { get; set; }
    }
}
