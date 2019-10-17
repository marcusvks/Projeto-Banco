using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDominio;
using TreinamentoInfra.Interface;

namespace TreinamentoInfra
{
    public static class Initializer
    {
        public static void StartDao(this IServiceCollection services)
        {
            services.AddScoped<IDao<Agencia>, AgenciaDao>();
            services.AddScoped<IDao<ContaBancaria>, ContaBancariaDao>();
            services.AddScoped<IDao<Funcionario>, FuncionarioDao>();
            services.AddScoped<IDao<Pessoa>, PessoaDao>();
        }
    }
}
