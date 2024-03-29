﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    abstract class Conta
    {
        public int Agencia { get; set; }
        public DateTime DataAbertura { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }

        public abstract decimal Depositar(decimal valor);
        public abstract decimal Retirar(decimal valor);

    }
    
}
