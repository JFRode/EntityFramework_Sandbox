using EntitySandbox.context;
using EntitySandbox.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySandbox.application
{
    class ProdutoAplicacao
    {
        public DbContext banco { get; set; }

        public ProdutoAplicacao()
        {
            banco = new DbContext();
        }

        public void salvar(Produto produto)
        {
            banco.Produtos.Add(produto);
            banco.SaveChanges();
        }

        public IEnumerable<Produto> listar()
        {
            return from c in banco.Produtos select c;
        }

        public void alterar(Produto produto)
        {
            Produto produtoAux = banco.Produtos.Where(x => x.Id == produto.Id).First();
            produtoAux.Nome = produto.Nome;
            banco.SaveChanges();
        }

        public void excluir(int Id)
        {
            Produto produtoExclusao = banco.Produtos.Where(x => x.Id == Id).First();
            banco.Set<Produto>().Remove(produtoExclusao);
            banco.SaveChanges();
        }
    }
}
