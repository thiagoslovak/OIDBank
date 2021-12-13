using System;
using System.Collections.Generic;

namespace OIDBank
{
    class Program
    {
        static List<TBanco> listContas = new List<TBanco>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario(); 

             while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirContas();
                        break;
                    case "3":
                        TransferirConta();
                        break;
                    case "4":
                        SaqueConta();
                        break;
                    case "5":
                        DepositarConta();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }   
        }

        private static void TransferirConta()
        {
            Console.WriteLine("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da conta desitno: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            //lista de contas origem. transferir(valor da transferencia e a lista conta destino)
            listContas[indiceContaOrigem].chamaTransferencia(valorTransferencia, listContas[indiceContaDestino]);
        }

        private static void DepositarConta()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].chamaDeposito(valorDeposito);
        }

        private static void InserirContas()
        {
            Console.WriteLine("Inserir nova conta");

            Console.WriteLine("Digite 1 para Conta Fisica ou 2 para Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            
            TBanco novaConta = new TBanco(tipoConta: (TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome);
            listContas.Add(novaConta);
        }
        private static void SaqueConta()
        {
            Console.WriteLine("Digite o número da Conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].chamaSaque(valorSaque); 
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar Contas");

            if(listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int i=0; i < listContas.Count; i++)
            {
                TBanco conta = listContas[i];
                Console.WriteLine("#{0} - ", i);
                Console.WriteLine(conta);
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("OID Bank a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario; 
        }
    }
}
