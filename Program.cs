using ExercicioFixacaoConstrutores;
using System;
using System.Globalization;

namespace ExFixacaoConstrutores {
    class Constutores {
        static void Main(string[] args) {
            ContaBank conta;

            Console.Write( "Entre o número da conta: " );
            int numero = int.Parse( Console.ReadLine() );
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Hávera depósito inicial (s / n)? ");
            char resposta = char.Parse( Console.ReadLine() );
            if (resposta == 's' || resposta == 'S') {
                Console.Write("Entre o valor do deposito inicial: ");
                double depositoInicial = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
                conta = new ContaBank(numero, titular, depositoInicial);
            }
            else { 
            conta = new ContaBank(numero, titular);
            }
            Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:  ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:  ");
            Console.WriteLine(conta);

        }




    }
}