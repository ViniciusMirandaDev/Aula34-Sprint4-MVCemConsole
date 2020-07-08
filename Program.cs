using System;
using Aula34_Sprint4_MVCemConsole.Controllers;

namespace Aula34_Sprint4_MVCemConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produto = new ProdutoController();
            produto.Listar();
            produto.Filtrar("7500");
        }
    }
}
