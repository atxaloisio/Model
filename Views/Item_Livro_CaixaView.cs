using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Item_Livro_CaixaView
    {
        public Item_Livro_CaixaView()
        { }

        public long? Id { get; set; }
        public long? Id_livro { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        public string documento { get; set; }
        public decimal? valor { get; set; }        
        public string usuario_inclusao { get; set; }        
    }
}
