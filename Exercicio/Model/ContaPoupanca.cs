using Exercicio.Exception1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {

        //Atributo
        private readonly decimal _rendimento;

        //Propriedade
        public decimal Taxa { get; set; }

        public override decimal Depositar(decimal valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public override decimal Retirar(decimal valor)
        {
           if (Saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }
            return valor;
        }

        public decimal CaculaRetornoInvestimento(decimal valor)
        {
            return Saldo * valor;
        }

        public ContaPoupanca()
        {

        }

        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;               
        }
    }
}
