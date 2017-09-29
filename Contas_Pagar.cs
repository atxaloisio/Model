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
    
    public partial class Contas_Pagar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contas_Pagar()
        {
            this.item_livro_caixa = new HashSet<Item_Livro_Caixa>();
        }
    
        public long Id { get; set; }
        public Nullable<long> Id_fornecedor { get; set; }
        public string Documento { get; set; }
        public Nullable<decimal> valor { get; set; }
        public Nullable<System.DateTime> vencimento { get; set; }
        public Nullable<int> categoria { get; set; }
        public Nullable<System.DateTime> previsao { get; set; }
        public Nullable<System.DateTime> pagamento { get; set; }
        public string pago { get; set; }
        public string observacao { get; set; }
        public Nullable<long> Id_empresa { get; set; }
        public Nullable<long> Id_filial { get; set; }
        public Nullable<System.DateTime> inclusao { get; set; }
        public string usuario_inclusao { get; set; }
        public Nullable<System.DateTime> alteracao { get; set; }
        public string usuario_alteracao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item_Livro_Caixa> item_livro_caixa { get; set; }
        public virtual Cliente cliente { get; set; }
        public virtual Empresa empresa { get; set; }
        public virtual Filial filial { get; set; }
    }
}
