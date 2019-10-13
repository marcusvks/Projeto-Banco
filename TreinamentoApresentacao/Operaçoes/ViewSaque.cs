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
    public class ViewSaque
    {
        public void RealizaSaque(OperacoesServices operacoesServices, ContaBancariaServices contaServices, ViewContaBancaria viewConta)
        {
            Console.Clear();

            Console.WriteLine("Informe o ID da sua conta bancaria");
            int IdConta = Convert.ToInt32(Console.ReadLine());

            ContaBancaria contaOrigem = contaServices.BuscaPorId(IdConta);

            if (contaOrigem != null)
            {
                Operacao operacao = new Operacao();

                Console.WriteLine("\nInforme o valor a ser sacado:\n");
                double valor = Convert.ToDouble(Console.ReadLine());

                if (contaOrigem.Saldo < valor)
                {
                    Console.WriteLine("Voce não tem saldo suficiente para realizar este saque");
                }
                else
                {
                    contaOrigem.Saque(valor);
                    operacao.RealizaOperacao(contaOrigem, contaOrigem, 2, valor);

                    operacoesServices.AdicionaNovaOperacao(operacao);

                    Console.WriteLine("\nOperacao realizada com sucesso");
                }
            }
            else
            {
                Console.WriteLine("Conta não identificada");
            }
        }
    }
}
