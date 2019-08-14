using Microsoft.Extensions.DependencyInjection;
using vxTel.Adapter.Application.Contract.PlanoTelefonia;
using vxTel.Domain.Interfaces;
using vxTel.Domain.Notifications;
using vxTel.Repository.Context;
using vxTel.Repository.Repository;
using vxTel.UseCase.PlanoTelefoniaUseCase;

namespace vxTel.CrossCutting.IoC
{
    public class NativeContainerOfDependencyInjection
    {
        public static void Register(IServiceCollection services)
        {
            //contexts
            services.AddScoped<VxTelContext>();

            //repositories
            services.AddScoped<IPlanoTelefoniaRepository, PlanoTelefoniaRepository>();
            services.AddScoped<ITarifaLigacaoRepository, TarifaLigacaoRepository>();

            //adapter - applications
            services.AddScoped<ICalcularValorLigacao, CalcularValorDeUmaLigacao>();

            //notifications
            services.AddSingleton<INotification, Notification>();
        }
    }
}