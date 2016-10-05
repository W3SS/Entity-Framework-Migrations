using System.Collections.Generic;
using System.Linq;
using Repositorio;
using Dominio;
using System.Data.Entity;

namespace Aplicacao
{

    public class CategoriaAplicacao
    {
        public DBProduto banco { get; set; }
        public CategoriaAplicacao()
        {
            banco = new DBProduto();
        }
        public void Salvar(Categoria categoria)
        {
            banco.Categorias.Add(categoria);
            banco.SaveChanges();
        }
        public IEnumerable<Categoria> Listar()
        {
            return banco.Categorias.ToList();
        }
        public void Alterar(Categoria categoria)
        {
            Categoria categoriaSalvar = banco.Categorias.Where(x => x.Id == categoria.Id).First();
            categoriaSalvar.Descricao = categoria.Descricao;
            banco.SaveChanges();
        }
        public void Ecluir(int Id)
        {
            Categoria CategoriaExcluir = banco.Categorias.Where(x => x.Id == Id).First();
            banco.Set<Categoria>().Remove(CategoriaExcluir);
            banco.SaveChanges();
        }

    }
}
