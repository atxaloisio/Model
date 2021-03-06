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
    
    public partial class Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresa()
        {
            this.filials = new HashSet<Filial>();
            this.item_livro_caixa = new HashSet<Item_Livro_Caixa>();
            this.livro_caixa = new HashSet<Livro_Caixa>();
            this.contas_pagar = new HashSet<Contas_Pagar>();
        }
    
        public long Id { get; set; }
        public Nullable<long> codigo_empresa { get; set; }
        public string codigo_empresa_integracao { get; set; }
        public string cnpj { get; set; }
        public string razao_social { get; set; }
        public string nome_fantasia { get; set; }
        public string logradouro { get; set; }
        public string endereco { get; set; }
        public string endereco_numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string codigo_pais { get; set; }
        public Nullable<System.DateTime> data_adesao_sn { get; set; }
        public string telefone1_ddd { get; set; }
        public string telefone1_numero { get; set; }
        public string telefone2_ddd { get; set; }
        public string telefone2_numero { get; set; }
        public string fax_ddd { get; set; }
        public string fax_numero { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string cnae { get; set; }
        public string cnae_municipal { get; set; }
        public string inscricao_estadual { get; set; }
        public string inscricao_municipal { get; set; }
        public string inscricao_suframa { get; set; }
        public Nullable<sbyte> regime_tributario { get; set; }
        public string inativa { get; set; }
        public string gera_nfse { get; set; }
        public string optante_simples_nacional { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Filial> filials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item_Livro_Caixa> item_livro_caixa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Livro_Caixa> livro_caixa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contas_Pagar> contas_pagar { get; set; }
    }
}
