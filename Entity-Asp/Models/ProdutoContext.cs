using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Asp.Models
{
    //CLASSE QUE ERDA OS ATRIBUTOS DA CLASSE DBCONTEXT
    public class ProdutoContext : DbContext
    {
        //INSERE A CONFIGURAÇÃO DA VARIAVEL DE CONEXÃO
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
        }
        // CRIA A TABELA PRODUTOS DENTRO DO BANCO DE DADOS APARTIR DO ENTITY FRAMEWORK
        public DbSet<Produto> produtos { get; set; }
    }
}
