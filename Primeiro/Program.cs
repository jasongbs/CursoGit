using Primeiro;
using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
     
            Console.Write("Entre com número da conta: ");
            c.NConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o nome do titular da conta: ");
            c.Titular = Console.ReadLine();

            Console.Write("Havera depósito inicial do "+c.Titular+" (s/n)?");
            char operacao = char.Parse(Console.ReadLine());

            if (operacao == 's' || operacao == 'S'){
                Console.WriteLine("Entre um valor para depósito incial: ");
                c.deposito(double.Parse(Console.ReadLine()));
            }

            c.listarDados();

            Console.WriteLine("Entre um valor para depósito: ");
            c.deposito(double.Parse(Console.ReadLine()));
            c.listarDados();

            Console.WriteLine("Entre um valor para Saque: ");
            c.saque(double.Parse(Console.ReadLine()));
            c.listarDados();
        }
    }
}
  