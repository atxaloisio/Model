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
    
    public partial class Livro_Caixa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Livro_Caixa()
        {
            this.item_livro_caixa = new HashSet<Item_Livro_Caixa>();
        }
    
        public long Id { get; set; }
        public Nullable<System.DateTime> data { get; set; }
        public Nullable<decimal> saldo_inicial { get; set; }
        public Nullable<decimal> saldo_final { get; set; }
        public Nullable<System.DateTime> inclusao { get; set; }
        public string usuario_inclusao { get; set; }
        public Nullable<System.DateTime> alteracao { get; set; }
        public string usuario_alteracao { get; set; }
        public Nullable<long> Id_empresa { get; set; }
        public Nullable<long> Id_filial { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item_Livro_Caixa> item_livro_caixa { get; set; }
        public virtual Empresa empresa { get; set; }
        public virtual Filial filial { get; set; }
    }
}
