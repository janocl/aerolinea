//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aerolinea.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empresa
    {
        public Empresa()
        {
            this.Vuelo = new HashSet<Vuelo>();
        }
    
        public int Id { get; set; }
        public string Run { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
    
        public virtual ICollection<Vuelo> Vuelo { get; set; }
    }
}
