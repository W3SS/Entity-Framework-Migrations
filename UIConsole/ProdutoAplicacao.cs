using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class ProdutoAplicacao
    {
        public DBProduto banco { get; set; }
        public ProdutoAplicacao()
        {
            banco = new DBProduto();
        }

        public void Salvar(Produto produto)
        {
            banco.Produtos.Add(produto);
            banco.SaveChanges();
        }

        public IEnumerable<Produto> Listar()
        {
            return banco.Produtos.ToList();
        }
        public void Alterar(Produto produto)
        {
            Produto produtoSalvar = banco.Produtos.Where(x => x.Id == produto.Id).First();
            produtoSalvar.Nome = produto.Nome;
            banco.SaveChanges();
        }
        public void Excluir(int Id)
        {
            Produto produtoExcluir = banco.Produtos.Where(x => x.Id == Id).First();
            banco.Set<Produto>().Remove(produtoExcluir);
            banco.SaveChanges();
        }

    }
}
