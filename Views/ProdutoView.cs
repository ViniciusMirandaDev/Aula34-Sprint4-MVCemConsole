using System.Collections.Generic;
using System;
using Aula34_Sprint4_MVCemConsole.Models;

namespace Aula34_Sprint4_MVCemConsole.Views
{
    public class ProdutoView
    {
        
        public void MostrarNoConsole(List<Produto> lista)
        {
            foreach(Produto item in lista)
            {
                Console.Write($"R$ {item.Preco} - {item.Nome } \n");
            }
        }

    }
}