using System.Collections.Generic;
using System.Linq;
using Repositorio;
using Dominio;
using System.Data.Entity;

namespace Aplicacao
{
    public class ListaDeProdutoAplicacao
    {
        //
        //rfcvgh
        //esrtfhjkggjhhghj
        public DBProduto banco { get; set; }

        public ListaDeProdutoAplicacao()
        {
            banco = new DBProduto();
            
        }

        public void Salvar(ListaDeProduto ListaDeProduto)
        {
            ListaDeProduto.Produtos = ListaDeProduto.Produtos.Select(produto => banco.Produtos.FirstOrDefault(x => x.Id == produto.Id)).ToList();
            banco.ListaDeProdutos.Add(ListaDeProduto);
            banco.SaveChanges();
        }

        public IEnumerable<ListaDeProduto> Listar()
        {
            return banco.ListaDeProdutos
                .Include(x => x.Produtos)
                .Include(x => x.Produtos.Select(c => c.Categoria))
                .ToList();
        }
        public void Alterar(ListaDeProduto listaDeProduto)
        {
            ListaDeProduto listaSalvar = banco.ListaDeProdutos.Where(x => x.Id == listaDeProduto.Id).First();
            listaSalvar.Produtos = listaDeProduto.Produtos.Select(produto => banco.Produtos.FirstOrDefault(x => x.Id == produto.Id)).ToList();
            listaSalvar.Descricao = listaDeProduto.Descricao;
            banco.SaveChanges();

        }
        public void Excluir(int Id)
        {
            ListaDeProduto listaExcluir = banco.ListaDeProdutos.Where(x => x.Id == Id).First();
            listaExcluir.Produtos = null;  // Linha inserida pois o EF nao pode ter dependencias
            banco.Set<ListaDeProduto>().Remove(listaExcluir);
            banco.SaveChanges();

        }
    }
}
