using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Asp.Models
{
    public class Inicializar_banco
    {
        public static void Initialize(ProdutoContext context)
        {
            context.Database.EnsureCreated();
            //PROCURAR DADOS DENTRO DO BANCO
            if (context.produtos.Any())
            {
                return; //o BD ja esta alimentado
            }
            var produtos = new Produto[]
            {
                new Produto{nome = "Borracha", Preco=3.99m},
                new Produto{nome= "Lapís", Preco=2.99M}
            };
            foreach(Produto p in produtos)
            {
                context.produtos.Add(p);
            }
            context.SaveChanges();
        }
    }
}
