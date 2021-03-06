﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ContaBancaria
{
    class Conta
    {
        public string Nome { get;  set; }
        public int ContaDig { get; private set; }
        public double Saldo { get; private set; }


        public Conta(string nome, int contaDig)
        {
            Nome = nome;
            ContaDig = contaDig;
            
        }

        public void Deposito(double x)
        {
            Saldo = Saldo + x;
        }

        public void Saque(double x)
        {
            Saldo = Saldo - x - 5.00;
        }

        public override string ToString()
        {
            return "Titular: " + Nome + ", Conta: " + ContaDig  + " Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }   
}
