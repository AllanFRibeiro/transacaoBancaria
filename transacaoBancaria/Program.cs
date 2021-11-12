using System;

namespace transacaoBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double saldo = 0, valor ;

            Console.WriteLine("Digite a opção desejada\n" +
                "1- Depósito\n" +
                "2 - Saque\n" +
                "3 Consulta Saldo");

            opcao = Convert.ToInt32(Console.ReadLine());    

            switch (opcao)
            {
                case 1: //DEPÓSITO
                    Console.WriteLine("Digite o Valor do seu depósito");
                    valor = Convert.ToDouble(Console.ReadLine());
                    saldo += valor;
                    Console.WriteLine("Seu depósito de {0}, foi feito com sucesso", saldo.ToString("0.00"));

                    break;
                case 2: //SAQUE
                    Console.WriteLine("Digite o Valor do saque");
                    valor = Convert.ToDouble(Console.ReadLine());
                    saldo -= valor;
                    Console.WriteLine("Seu saque de {0}, foi feito com sucesso", saldo.ToString("0.00"));
                    break;
                case 3: // SALDO
                    Console.WriteLine("Digite o Valor do saque");
                    valor = Convert.ToDouble(Console.ReadLine());
                    saldo -= valor;
                    Console.WriteLine("Seu saldo é de {0}", saldo.ToString("0.00"));
                    break;
                default:
                    Console.WriteLine("Não existe essa opção, por favor digite 1 para depósito, 2 para saque ou 3 para ver saldo");
                    break;
            }

        }
    }
    
}
