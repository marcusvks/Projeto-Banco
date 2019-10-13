using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoAplicacao.Features.ContaBancariaServices;
using TreinamentoAplicacao.Features.OperacoesServices;
using TreinamentoApresentacao.Models;
using TreinamentoDominio;

namespace TreinamentoInfra.Operaçoes

{
    public class ViewTransferencia
    {
        public void RealizaTransferencia(ViewContaBancaria viewConta, OperacoesServices operacoesServices, ContaBancariaServices contaServices)
        {
            Console.Clear();
            
            Console.WriteLine("Informe o ID da sua conta bancaria");
            int IdContaOrigem = Convert.ToInt32(Console.ReadLine());

            ContaBancaria contaOrigem = contaServices.BuscaPorId(IdContaOrigem);

            if (contaOrigem != null)
            {
                Operacao operacao = new Operacao();

                Console.WriteLine("\nConfirme os dados: \n");
                viewConta.ListaEFormata();

                Console.WriteLine("\nInforme o ID da conta bancaria que vai receber a transferencia");
                int IdContaDestino = Convert.ToInt32(Console.ReadLine());

                ContaBancaria contaMovimentada = contaServices.BuscaPorId(IdContaDestino);

                if (contaMovimentada != null)
                {
                    Console.WriteLine("\nConfirme os dados: \n");
                    viewConta.ListaEFormata();

                    Console.WriteLine("\nInforme o valor a ser transferido: ");
                    double ValorTransferencia = Convert.ToDouble(Console.ReadLine());

                    if (contaOrigem.Saldo < ValorTransferencia)
                    {
                        Console.WriteLine("Voce não tem saldo suficiente para fazer este depósito");
                    }
                    else
                    {
                        contaOrigem.Saque(ValorTransferencia);
                        contaMovimentada.Deposito(ValorTransferencia);

                        operacao.RealizaOperacao(contaMovimentada, contaOrigem, 3, ValorTransferencia);

                        operacoesServices.AdicionaNovaOperacao(operacao);

                        Console.WriteLine("Operacao realizada com sucesso");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhuma conta encontrada");
                }

            }
            else
            {
                Console.WriteLine("Nenhuma conta encontrada");
            }
        }
    }
}
