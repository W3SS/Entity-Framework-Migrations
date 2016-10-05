using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoriaAplicacao appCategoria = new CategoriaAplicacao();

            Categoria cat01 = new Categoria();
            cat01.Descricao = "Pacotes";

            //appCategoria.Salvar(cat01);

            ProdutoAplicacao appProduto = new ProdutoAplicacao();
            Produto prod01 = new Produto();
            prod01.Nome = "Açucar";
            prod01.Categoria = appCategoria.Listar().Where(x => x.Id == 4).FirstOrDefault();

            appProduto.Salvar(prod01);

            Console.WriteLine("Lista de Produtos");

            var listaDeProdutos = appProduto.Listar();
            foreach (var produto in listaDeProdutos)
            {
                Console.WriteLine("{0} - {1} - {2}", produto.Id, produto.Nome, produto.Categoria.Descricao);
            }

            Console.WriteLine("Lista de Categorias");
            var listaDeCategorias = appCategoria.Listar();
            foreach (var categoria in listaDeCategorias)
            {
                Console.WriteLine("{0} - {1}", categoria.Id, categoria.Descricao);
            }
            Console.ReadKey();
        }
    }
}
