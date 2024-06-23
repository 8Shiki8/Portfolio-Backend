using _1Aplication.Services;
using _2Domain.DTOs;
using _2Domain.Interfaces;
using _2Domain.Interfaces.Queries;
using _3AccessData;
using _3AccessData.Commands;
using _3AccessData.Commands.Repository;
using _3AccessData.Queries;
using _3AccessData.Validation;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore
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
            services.AddDbContext<GStoreDB>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("SQLConnection")));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GameStore", Version = "v1" });
            });
            //Agregando politicas de acceso AddCors
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAnyOrigin",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
            //inyecciond e depencias

            //services.AddScoped<GenericRepository, GenericRepository>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IJuegoService, JuegoService>();
            services.AddTransient<IUsuarioService, UsuarioService>();

            services.AddTransient<IGenericRepository, GenericRepository>();

            services.AddTransient<ICategoriaQuery, CategoriaQuery>();
            services.AddTransient<IJuegoQuery, JuegoQuery>();
            services.AddTransient<IUsuarioQuery, UsuarioQuery>();

            //fluent validation
            services.AddFluentValidationAutoValidation();
            services.AddTransient<IValidator<UsuarioDTO>, UsuarioValidation>();
            services.AddTransient<IValidator<CategoriaDTO>, CategoriaValidation>();
            services.AddTransient<IValidator<JuegoDTO>, JuegoValidation>();





        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("AllowAnyOrigin");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GameStore v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
