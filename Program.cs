using System;

namespace M_todoConstrutor_16
{
    class Program : Produto
    {
        static void Main(string[] args)
        // instancia com o metodo sonstritor sem argumentos
        {
            Produto tenis = new Produto(90854332, "Air max 97", "Parte de cima em couro, material sintético e tecido", 237);
            System.Console.Write("Código do tênis: ");
            System.Console.WriteLine(tenis.Codigo);
            System.Console.Write("Nome do tênis: ");
            System.Console.WriteLine(tenis.Nome);
            System.Console.Write("Descrição: ");
            System.Console.WriteLine(tenis.Descricao);
            System.Console.Write("Quantidade de Produtos em estoque: ");
            System.Console.WriteLine(tenis.Estoque);
           


        }
    }
}
