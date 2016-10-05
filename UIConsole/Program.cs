using System;
using System.Linq;
using Aplicacao;
using Dominio;
using System.Collections.Generic;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Categoria
            var appCategoria = new CategoriaAplicacao();
            //var objCategoria = new Categoria
            //{
            //    Descricao = "Enlatados"
            //};
            //appCategoria.Salvar(objCategoria);

            //var listaDeCategorias = appCategoria.Listar();
            //foreach (var lisaDeCategoria in listaDeCategorias)
            //{
            //    Console.WriteLine("{0}", lisaDeCategoria.Descricao);
            //}
            //Console.ReadKey();


            // Produto
            var appProduto = new ProdutoAplicacao();
            //var objProduto = new Produto
            //{
            //    Nome = "Sardinha",
            //    Categoria=appCategoria.Listar().FirstOrDefault()
            //};
            //appProduto.Salvar(objProduto);

            //var listaDeProdutos = appProduto.Listar();
            //foreach (var listaDeProduto in listaDeProdutos)
            //{
            //    Console.WriteLine("{0} - {1}", listaDeProduto.Nome, listaDeProduto.Categoria.Descricao);
            //}
            //Console.ReadKey();


            // Lista de Produto
            var appLista = new ListaDeProdutoAplicacao();

            var objListaProdutos = new ListaDeProduto
            {
                Descricao = "Listas de Compras do Leandro"
            };
            var produto1 = appProduto.Listar().FirstOrDefault();
            objListaProdutos.Produtos = new List<Produto>
            {
                produto1
            };

            appLista.Salvar(objListaProdutos);
            var listas = appLista.Listar();

            foreach (var listaDeProduto in listas)
            {
                Console.WriteLine("{0}", listaDeProduto.Descricao);
                foreach (var produto in listaDeProduto.Produtos)
                {
                    Console.WriteLine(" {0} - {1}", produto.Nome, produto.Categoria.Descricao);
                }
            }
            Console.ReadKey();
        }
    }
}
