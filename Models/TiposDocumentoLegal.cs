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
    
    public partial class TiposDocumentoLegal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TiposDocumentoLegal()
        {
            this.DocumentosClientes = new HashSet<DocumentosCliente>();
        }
    
        public int CodigoTipoDocumento { get; set; }
        public string NombreTipoDocumento { get; set; }
        public bool Activo { get; set; }
        [JsonIgnore]

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosCliente> DocumentosClientes { get; set; }
    }
}
