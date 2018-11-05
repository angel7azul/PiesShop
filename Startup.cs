using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using PiesShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;//IConfiguration

namespace PiesShop
{ 
    #region Startup
     //Definir la canalizacion de las solicitudes de clientes (Clase Startup)
    //Se configuran todos los servicios que seran necesarios a travez de la aplicacion
    //1.- Configure Services 2.- Configure
    #endregion

    public class Startup
    {
        public  IConfiguration _configuration{get;}

        public Startup(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IPieRepository,PieRepository>(); 
            services.AddTransient<IPieRepository,MockPieRepository>(); 
            //La cadena de Coneccion se agrega en appsettings.json
            
            services.AddDbContext<AppDbContext>(op=>
            {
                op.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            });       
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
            app.UseNodeModules(env);//Agregar NodeModules
            app.UseMvcWithDefaultRoute(); // services.AddMvc() Todo va en orden, mvc al final
            /*
            Importa el orden
            npm install jquery
            dotnet add package OdeToCode.UseNodeModules --version 1.0.6
            npm install popper.js
            npm install bootstrap
            npm i font-awesome
             */
        }
    }
}
