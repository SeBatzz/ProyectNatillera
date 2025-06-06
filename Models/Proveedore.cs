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
    
    public partial class Proveedore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedore()
        {
            this.ContactosProveedors = new HashSet<ContactosProveedor>();
            this.EventosProveedores = new HashSet<EventosProveedore>();
            this.GastosEventoes = new HashSet<GastosEvento>();
        }
    
        public string DocumentoProveedor { get; set; }
        public string NombreCompania { get; set; }
        public string Direccion { get; set; }
        public int CodigoCiudad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int CodigoTipoServicio { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }

        [JsonIgnore]
        public virtual Ciudade Ciudade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<ContactosProveedor> ContactosProveedors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<EventosProveedore> EventosProveedores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<GastosEvento> GastosEventoes { get; set; }
        [JsonIgnore]
        public virtual TiposServicioProveedor TiposServicioProveedor { get; set; }
    }
}
