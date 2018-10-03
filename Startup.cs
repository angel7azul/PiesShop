using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace PiesShop
{ 
    #region Startup
     //Definir la canalizacion de las solicitudes de clientes (Clase Startup)
    //Se configuran todos los servicios que seran necesarios a travez de la aplicacion
    //1.- Configure Services 2.- Configure
    #endregion
   
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        #region Comentarios
        /*
        En este metodo, la tuberia de la solicitud se configurara, y esta coniste en una serie de componente
        encadenados unos detras de otros llamados componentes del MiddleWare, estos componentes 
        interceptaran la solicitud http entrante, y puede manejarla, cabiarla o simplemente pasarla al 
        sig componente de la tuberia
        */
        #endregion
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles(); //wwwroot/...
            app.UseMvcWithDefaultRoute(); // services.AddMvc() Todo va en orden, mvc al final
        }
    }
}
