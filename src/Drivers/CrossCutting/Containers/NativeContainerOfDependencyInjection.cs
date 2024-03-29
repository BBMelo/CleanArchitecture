﻿using Microsoft.Extensions.DependencyInjection;
using vxTel.Adapter.Application.Facade;
using vxTel.Adapter.Application.Interfaces;
using vxTel.Domain.Interfaces;
using vxTel.Domain.Notifications;
using vxTel.Repository.Context;
using vxTel.Repository.Repository;
using vxTel.UseCase.BoundedContexts.PlanoTelefonia;
using vxTel.UseCase.Interfaces;
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

            //usecases
            services.AddScoped<ICalcularPrecoTarifaPorPlano, CalcularPrecoTarifaPorPlano>();
            services.AddScoped<ICompararPrecoEntrePlano, CalcularTarifaLigacaoComPlanoESemPlano>();

            //adapter - applications            
            services.AddScoped<IPlanoTelefoniaApplication, PlanoTelefoniaFacade>();

            //notifications
            //services.AddScoped<INotification, Notification>();
            services.AddScoped<Notification>();
        }
    }
}