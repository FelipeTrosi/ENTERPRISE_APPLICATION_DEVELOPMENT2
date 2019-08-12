using _01_Fiap.UI._HelloWord.Model;
using System;

namespace _01_Fiap.UI._HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um carro
            Carro carro = new Carro();

            //Atibuir um codigo ao carro
            carro.Codigo = 10;
            carro.TipoCarro = TipoCarro.Sedan;


            //Exibir o código do carro
            Console.WriteLine(carro.Codigo);

            //Instanciar um carro 2
            Carro carro2 = new Carro()
            {
                Portas = 4,
                Valor = 10000
            };
        }
    }
}

