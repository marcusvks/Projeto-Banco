using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._2___MODEL;
using Treinamento._3___DAO;

namespace Treinamento._1___VIEW
{
    public class ViewSaque
    {
        public void RealizaSaque(Operacao operacao, RelatorioOperacaoDao relatorioDao, ContaBancariaDao contaDao, ViewContaBancaria viewConta)
        {
            Console.Clear();

            Console.WriteLine("Informe o ID da sua conta bancaria");
            int IdConta = Convert.ToInt32(Console.ReadLine());

            ContaBancaria contaOrigem = contaDao.BuscaContaPorId(IdConta);

            if (contaOrigem != null)
            {
                Console.WriteLine("\nConfirme os dados: \n");
                viewConta.FormataListaContaBancaria(contaDao);

                Console.WriteLine("\nInforme o valor a ser sacado:\n");
                double valor = Convert.ToDouble(Console.ReadLine());

                if (contaOrigem.Saldo < valor)
                {
                    Console.WriteLine("Voce não tem saldo suficiente para realizar este saque");
                }
                else
                {
                    contaOrigem.Saque(valor);
                    operacao.RealizaOperacao(contaOrigem, contaOrigem, 2);

                    relatorioDao.AdicionaNovaOperacao(operacao);

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
