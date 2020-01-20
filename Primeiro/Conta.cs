using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Conta
    {
        public string Titular { get; set; }
        public int NConta { get; set; }
        public double Saldo { get; set; }
      
      public void deposito(double valor){
            Saldo += valor;
        }

        public void saque(double valor)
        {
            Saldo -= valor + 5;
        }

        public void listarDados()
        {
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine("Conta " + NConta + ", Titular: " + Titular + ", Saldo: " + Saldo);
        }

    }
}
