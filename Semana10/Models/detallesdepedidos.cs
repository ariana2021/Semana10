//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Semana10.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class detallesdepedidos
    {
        public Nullable<int> idpedido { get; set; }
        public Nullable<int> idproducto { get; set; }
        public decimal preciounidad { get; set; }
        public int cantidad { get; set; }
        public decimal descuento { get; set; }
    
        public virtual Pedidos Pedidos { get; set; }
        public virtual productos productos { get; set; }
    }
}
