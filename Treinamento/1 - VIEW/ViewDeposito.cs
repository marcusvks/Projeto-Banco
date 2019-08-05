using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._2___MODEL;
using Treinamento._3___DAO;

namespace Treinamento._1___VIEW
{
    public class ViewDeposito
    {
        public void RealizaDeposito(ContaBancariaDao contaDao, ViewContaBancaria viewConta, Operacao operacao, RelatorioOperacaoDao relatorioDao)
        {
            Console.Clear();

            Console.WriteLine("Informe o ID da sua conta");
            int IdContaOrigem = Convert.ToInt32(Console.ReadLine());

            ContaBancaria contaOrigem = contaDao.BuscaContaPorId(IdContaOrigem);

            if (contaOrigem != null)
            {
                Console.WriteLine("\nConfirme os dados: \n");
                viewConta.FormataListaContaBancaria(contaDao);

                Console.WriteLine("Informe o ID da conta bancaria a qual irá receber o deposito:\n");
                int IdContaMovimentada = Convert.ToInt32(Console.ReadLine());

                ContaBancaria contaMovimentada = contaDao.BuscaContaPorId(IdContaMovimentada);

                if (contaMovimentada != null)
                {
                    Console.WriteLine("\nConfirme os dados: \n");
                    viewConta.FormataListaContaBancaria(contaDao);

                    Console.WriteLine("\nInforme o valor a ser depositado: ");
                    double ValorDeposito = Convert.ToDouble(Console.ReadLine());

                    if (contaMovimentada.Saldo < ValorDeposito && IdContaOrigem != IdContaMovimentada)
                    {
                        Console.WriteLine("Voce não tem saldo suficiente para fazer este depósito");
                    }
                    else
                    {
                        contaMovimentada.Deposito(ValorDeposito);
                        operacao.RealizaOperacao(contaMovimentada, contaOrigem, 1);

                        relatorioDao.AdicionaNovaOperacao(operacao);

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
                Console.WriteLine("Conta nao encontrada");
            }


            
        }
    }
}
