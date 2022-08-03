using Capoia.Catalogo.Application.Services;
using Capoia.Catalogo.Data;
using Capoia.Catalogo.Data.Repository;
using Capoia.Catalogo.Domain;
using Capoia.Catalogo.Domain.Events;
using Capoia.Core.Bus;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Capoia.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddScoped<IMediatrHandler, MediatrHandler>();

            // Catalogo
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<CatalogoContext>();

            services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();
        }
    }
}
