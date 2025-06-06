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
    
    public partial class Lugare
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lugare()
        {
            this.AlquileresLugars = new HashSet<AlquileresLugar>();
            this.Eventos = new HashSet<Evento>();
        }
    
        public int CodigoLugar { get; set; }
        public string NombreLugar { get; set; }
        public string Direccion { get; set; }
        public int CodigoCiudad { get; set; }
        public Nullable<int> CapacidadPersonas { get; set; }
        public Nullable<decimal> CostoPorDia { get; set; }
        public string ContactoPrincipal { get; set; }
        public string TelefonoContacto { get; set; }
        public bool Activo { get; set; }
        [JsonIgnore]

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlquileresLugar> AlquileresLugars { get; set; }
        [JsonIgnore]
        public virtual Ciudade Ciudade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<Evento> Eventos { get; set; }
    }
}
