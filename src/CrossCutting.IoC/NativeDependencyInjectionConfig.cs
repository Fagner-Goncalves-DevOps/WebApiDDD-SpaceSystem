using Application.Interfaces;
using Application.Services;
using CrossCutting.Identity.Services;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Generics;
using Infra.Data.Repositories;
using Infra.Data.Repositories.Generics;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.IoC
{
    public class NativeDependencyInjectionConfig
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infra - Data
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IContratoRepository, ContratoRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IParcelaRepository, ParcelaRepository>();
            services.AddScoped<IPlanoRepository, PlanoRepository>();

            // Application - Servicos
            services.AddScoped<IPessoaService, PessoaService>();
            services.AddScoped<IContratoService, ContratoService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IParcelaService, ParcelaService>();
            services.AddScoped<IPlanoService, PlanoService>();

            // Infra - Identity
            services.AddSingleton<IJwtFactory, JwtFactory>();
            // services.AddScoped<IUser, AspNetUser>();Implementar


        }
    }
}
