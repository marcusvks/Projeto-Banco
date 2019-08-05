using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._3___DAO;

namespace Treinamento._1___VIEW
{
    public class ViewRelatorioOperacoes
    {
        public void VisualizaRelatorioDeOperacoes(RelatorioOperacaoDao relatorioDao)
        {
            Console.Clear();

            foreach (var operacao in relatorioDao.RetornaOperacoes())
            {
                Console.WriteLine($"Id desta operação: {operacao.Id} \n Conta Movimentada: \n Nome: {operacao.ContaMovimentada.DonoDaConta.Nome} \n Conta: {operacao.ContaMovimentada.Conta}\n" +
                    $" Agencia: {operacao.ContaMovimentada.Agencia.Nome} \n\n Conta Origem: \n Nome: {operacao.ContaOrigem.DonoDaConta.Nome} \n Conta: {operacao.ContaOrigem.Conta} \n" +
                    $"Agencia: {operacao.ContaOrigem.Agencia.Nome} \n Operacao Realizada: {operacao.OperacaoVinculada} \n Data da Operacao: {operacao.DataOperacao}");
            }
        }
    }
}
