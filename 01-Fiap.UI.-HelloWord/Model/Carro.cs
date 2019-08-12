using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI._HelloWord.Model
{
    class Carro : Veiculo , IAutomatico
    {
        //Métodos
        public override void Ligar()
        {
            Console.WriteLine("Veículo em movimento !");
        }

        public override void Andar()
        {
            Console.WriteLine("Carro andando");
        }

        public void TrocarMarcha()
        {
            Console.WriteLine("Trocando de marcha !");
        }


        //Construtor
        public Carro()
        {

        }
        public Carro (string cor): base(cor)
        {

        }   

        //Propriedades (get e set)
        public int Portas { get; set; }
        public decimal Valor { get; set; }

        public TipoCarro TipoCarro { get; set; }

    }
}
