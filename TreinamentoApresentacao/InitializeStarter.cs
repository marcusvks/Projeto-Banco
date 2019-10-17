using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoAplicacao;
using TreinamentoInfra;

namespace TreinamentoApresentacao
{
    public static class InitializeStarter
    {
        public static ServiceProvider Start()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.StartDao();
            serviceCollection.StartAplication();

            ServiceProvider services = serviceCollection.BuildServiceProvider();

            return services;
        }

    }
}
