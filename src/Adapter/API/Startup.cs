using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using vxTel.CrossCutting.IoC;
using vxTel.WebServiceAdapter.Middleware;

namespace vxTel.WebServiceAdapter
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddMvc(options =>
            {
                options.OutputFormatters.Remove(new XmlDataContractSerializerOutputFormatter());
                options.Filters.Add<ControllerStateFilter>();
            })
           .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
           .AddJsonOptions(opcoes =>
           {
               opcoes.SerializerSettings.NullValueHandling =
                   Newtonsoft.Json.NullValueHandling.Ignore;
           });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            NativeContainerOfDependencyInjection.Register(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

         
            app.UseHttpsRedirection();
            app.UseMvc();
        }        
    }
}
