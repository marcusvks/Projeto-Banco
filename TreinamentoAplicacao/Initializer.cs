using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoAplicacao.Features.AgenciasServices;
using TreinamentoAplicacao.Features.ContaBancariaServices;
using TreinamentoAplicacao.Features.FuncionariosServices;
using TreinamentoAplicacao.Features.PessoasServices;
using TreinamentoDominio;
using TreinamentoDominio.Interfaces;

namespace TreinamentoAplicacao
{
    public static class Initializer
    {
        public static void StartAplication(this IServiceCollection services)
        {
            services.AddScoped<IServices<Agencia>, AgenciaServices>();
            services.AddScoped<IServices<ContaBancaria>, ContaBancariaServices>();
            services.AddScoped<IServices<Funcionario>, FuncionariosServices>();
            services.AddScoped<IServices<Pessoa>, PessoasServices>();
        }
    }
}
