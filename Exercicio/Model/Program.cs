using Exercicio.Model;
using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new ContaCorrente()
            {
                Agencia = 1,
                Numero = 1,
                Saldo = 9000,
                DataAbertura = DateTime.Now,
                Tipo = TipoConta.Espcial
            };

            var cp = new ContaPoupanca(0.03m)
            {
                Agencia = 2,
                DataAbertura = DateTime.Now,
                Numero = 2,
                Saldo = 110000,
                Taxa = 100
            };
        }
    }

}
