//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_Orden
    {
        public int Id { get; set; }
        public int CarroId { get; set; }
        public int UsuarioId { get; set; }
        public int LocalizacionId { get; set; }
    
        public virtual t_Auto t_Auto { get; set; }
        public virtual t_Localidad t_Localidad { get; set; }
        public virtual t_Usuarios t_Usuarios { get; set; }
    }
}
