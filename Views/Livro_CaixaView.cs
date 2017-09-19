using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Livro_CaixaView
    {
        public Livro_CaixaView()
        { }

        public long Id { get; set; }
        public Nullable<System.DateTime> data { get; set; }
        public Nullable<decimal> saldo_inicial { get; set; }
        public Nullable<decimal> saldo_final { get; set; }
        public Nullable<System.DateTime> inclusao { get; set; }
        public string usuario_inclusao { get; set; }
        public Nullable<System.DateTime> alteracao { get; set; }
        public string usuario_alteracao { get; set; }
    }
}
