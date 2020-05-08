using ApiChamado.Domain.Model;
using ApiChamado.Domain.Validator;
using ApiChamado.Service.Repository;
using ApiChamado.Service.RepositoryImpl;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiChamado.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection DependencyConfiguration(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddScoped<IChamadoRepository, ChamadoRepositoryImpl>();
            services.AddScoped<ILivroRepository, LivroRespositoryImpl>();
            services.AddTransient<IClienteRepository, ClienteRepositoryImpl>();
            services.AddTransient<IEmprestimoRepository, EmprestimoRepositoryImpl>();
            services.AddScoped<IValidator<Chamado>, ChamadoValidator>();
            services.AddScoped<IValidator<Livro>, LivroValidator>();
            services.AddScoped<IValidator<Cliente>, ClienteValidator>();
            services.AddScoped<IValidator<Emprestimo>, EmprestimoValidator>();

            return services;
        }
    }
}
