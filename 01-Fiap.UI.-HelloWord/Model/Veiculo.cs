using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI._HelloWord.Model
{
    abstract class Veiculo
    {
        //Métodos
        public abstract void Ligar();

        //virtual -> Permite a sobrescrita do método
        public virtual void Andar()
        {
            Console.WriteLine("Veículo em movimento !");
        }

        //Construtor

        public Veiculo()
        {

        }

        public Veiculo(string cor)
        {
            this.Cor = cor;
        }
        
        //Atributos - Fields/Campos
        private int _codigo;

        //Métodos Gets/Sets

        public string Cor { get; set; }


        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

    }
}
