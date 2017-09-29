using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contas_PagarView
    {
        public Contas_PagarView()
        { }

        public long? Id { get; set; }
        public string fornecedor { get; set; }
        public string Documento { get; set; }
        public decimal? valor { get; set; }
        public DateTime? vencimento { get; set; }        
        public DateTime? previsao { get; set; }
        public DateTime? pagamento { get; set; }
        public bool pago { get; set; }
    }
}
