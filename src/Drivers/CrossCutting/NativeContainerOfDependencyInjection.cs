using Microsoft.Extensions.DependencyInjection;
using vxTel.Domain.Interfaces;
using vxTel.Domain.Notifications;
using vxTel.Repository.Context;
using vxTel.Repository.Repository;

namespace vxTel.CrossCutting.IoC
{
    public class NativeContainerOfDependencyInjection
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<VxTelContext>();
            services.AddScoped<IPlanoTelefoniaRepository, PlanoTelefoniaRepository>();
            services.AddSingleton<INotification, Notification>();
        }
    }
}