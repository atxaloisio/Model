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
    
    public partial class Conta_Corrente
    {
        public long Id { get; set; }
        public int nCodCC { get; set; }
        public string cCodCCInt { get; set; }
        public string descricao { get; set; }
        public string codigo_banco { get; set; }
        public string codigo_agencia { get; set; }
        public string conta_corrente1 { get; set; }
        public string nome_gerente { get; set; }
        public string tipo { get; set; }
        public string tipo_comunicacao { get; set; }
        public string cSincrAnalitica { get; set; }
        public Nullable<int> nTpTef { get; set; }
        public Nullable<decimal> nTaxaAdm { get; set; }
        public Nullable<int> nDiasVenc { get; set; }
        public Nullable<int> nNumParc { get; set; }
        public Nullable<int> nCodAdm { get; set; }
        public string cUtilPDV { get; set; }
        public string cModalidade { get; set; }
        public Nullable<decimal> saldo_inicial { get; set; }
        public Nullable<System.DateTime> saldo_data { get; set; }
        public Nullable<decimal> valor_limite { get; set; }
        public Nullable<System.DateTime> inclusao { get; set; }
        public string usuario_inclusao { get; set; }
        public Nullable<System.DateTime> alteracao { get; set; }
        public string usuario_alteracao { get; set; }
    }
}
