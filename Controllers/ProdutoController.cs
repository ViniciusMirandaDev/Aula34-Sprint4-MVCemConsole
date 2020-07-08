using System.Collections.Generic;
using Aula34_Sprint4_MVCemConsole.Models;
using Aula34_Sprint4_MVCemConsole.Views;

namespace Aula34_Sprint4_MVCemConsole.Controllers
{
    public class ProdutoController
    {
       
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar(){
            //Outro jeito de fazer
            //List<Produto> produtos = new List<Produto>();
            //produtos = produtoModel.Ler();
            produtoView.MostrarNoConsole( produtoModel.Ler() );
        }
        public void Filtrar(string _preco)
        {
            List<Produto> lista = produtoModel.Ler();
            lista = lista.FindAll(x => x.Preco == float.Parse(_preco));

            produtoView.MostrarNoConsole(lista);
        }

    }
}