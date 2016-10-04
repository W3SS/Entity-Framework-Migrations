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
            ProdutoAplicacao app = new ProdutoAplicacao();

            Produto produto01 = new Produto();
            //produto01.Id = 1;
            produto01.Nome = "Oleo";
            produto01.Categoria = "Vegetal";
            app.Salvar(produto01);
            //app.Excluir(2);

            IEnumerable <Produto> ProdutosNoBancoDeDados = app.Listar();
            foreach (var produtoNaLista in app.Listar())
            {
                Console.WriteLine("{0} - {1} - {2}", produtoNaLista.Id, produtoNaLista.Nome, produtoNaLista.Categoria);
            }            
            Console.ReadKey();
        }
    }
}
