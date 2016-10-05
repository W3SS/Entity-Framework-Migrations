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

            ListaDeProdutoAplicacao appLista = new ListaDeProdutoAplicacao();
            ProdutoAplicacao appProduto = new ProdutoAplicacao();

            //var lista01 = new ListaDeProduto();
            //var lista01 = appLista.Listar().Where(x=> x.Id ==1).FirstOrDefault();
            var lista01 = appLista.Listar().LastOrDefault();
            lista01.Descricao = "Cesta Basica de Rico";
            //lista01.Produtos = appProduto.Listar().Where(x => x.Categoria.Id == 2).ToList();
            lista01.Produtos = appProduto.Listar().ToList();
            //appLista.Alterar(lista01);
            appLista.Excluir(lista01.Id);

            var listas = appLista.Listar();
            foreach (var lista in listas)
            {
                Console.WriteLine("{0} - {1}", lista.Id, lista.Descricao);
                foreach (var produto in lista.Produtos)
                {
                    Console.WriteLine("    {0} - {1}", produto.Id, produto.Nome);
                }
            }

                //CategoriaAplicacao appCategoria = new CategoriaAplicacao();

                //Categoria cat01 = new Categoria();
                //cat01.Descricao = "Pacotes";

                ////appCategoria.Salvar(cat01);

                //ProdutoAplicacao appProduto = new ProdutoAplicacao();
                //Produto prod01 = new Produto();
                //prod01.Nome = "Açucar";
                //prod01.Categoria = appCategoria.Listar().Where(x => x.Id == 4).FirstOrDefault();

                //appProduto.Salvar(prod01);

                //Console.WriteLine("Lista de Produtos");

                //var listaDeProdutos = appProduto.Listar();
                //foreach (var produto in listaDeProdutos)
                //{
                //    Console.WriteLine("{0} - {1} - {2}", produto.Id, produto.Nome, produto.Categoria.Descricao);
                //}

                //Console.WriteLine("Lista de Categorias");
                //var listaDeCategorias = appCategoria.Listar();
                //foreach (var categoria in listaDeCategorias)
                //{
                //    Console.WriteLine("{0} - {1}", categoria.Id, categoria.Descricao);
                //}
                Console.ReadKey();
        }
    }
}
