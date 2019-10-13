using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoAplicacao.Features.OperacoesServices;

namespace TreinamentoInfra.Operaçoes
{
    public class ViewRelatorioOperacoes
    {
        public void VisualizaRelatorioDeOperacoes(OperacoesServices operacoesServices)
        {
            Console.Clear();

            if (operacoesServices.RetornaOperacoes().Count != 0)
            {
                foreach (var operacao in operacoesServices.RetornaOperacoes())
                {
                    Console.WriteLine($"\nId desta operação: {operacao.Id} \n Conta Movimentada: \n Nome: {operacao.ContaMovimentada.DonoDaConta.Nome} \n Conta: {operacao.ContaMovimentada.Conta}\n" +
                        $"Agencia: {operacao.ContaMovimentada.Agencia.Nome} \n\n Conta Origem: \n Nome: {operacao.ContaOrigem.DonoDaConta.Nome} \n Conta: {operacao.ContaOrigem.Conta} \n" +
                        $"Agencia: {operacao.ContaOrigem.Agencia.Nome} \n Operacao Realizada: {operacao.OperacaoVinculada} \n Data da Operacao: {operacao.DataOperacao} \n Valor: {operacao.Valor}");
                }
            }
            else
            {
                Console.WriteLine("Nenhuma operacao foi realizada ainda");
            }


        }
    }
}
