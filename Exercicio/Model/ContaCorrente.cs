using Exercicio.Exception1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    //sealed -> classe não poderá ser herdada
    sealed class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }

        public override decimal Depositar(decimal valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public override decimal Retirar(decimal valor)
        {
            if(Saldo < valor && Tipo == TipoConta.Comum)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= valor;
            return Saldo;
        }
    }
}
