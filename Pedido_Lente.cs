//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedido_Lente
    {
        public long Id { get; set; }
        public long Id_pedido_otica { get; set; }
        public Nullable<int> tipo { get; set; }
        public string marca_material { get; set; }
        public string observacoes { get; set; }
        public Nullable<System.DateTime> inclusao { get; set; }
        public string usuario_inclusao { get; set; }
        public Nullable<System.DateTime> alteracao { get; set; }
        public string usuario_alteracao { get; set; }
    
        public virtual Pedido_Otica pedido_otica { get; set; }
    }
}
