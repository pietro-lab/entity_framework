using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Entity_Asp.Models
{
    public class Produto
    {
        // DECLARAÇÃO DE VARIAVEIS UTILIZADAS NO APP
        public int Id { get; set; }
        public string nome { get; set; }
        public Decimal Preco { get; set; }
    }
}
