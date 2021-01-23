﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Conta
    {
        public string Nome { get; private set; }
        public int ContaDig { get; set; }
        private double Saldo;


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
            Saldo = Saldo - x;
        }

    }   
}
