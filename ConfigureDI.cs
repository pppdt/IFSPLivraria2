using AutoMapper;
using IFSPLivraria.App.Cadastros;
using IFSPLivraria.App.Models;
using IFSPLivraria.Domain.Base;
using IFSPLivraria.Domain.Entities;
using IFSPLivraria.Repository.Context;
using IFSPLivraria.Repository.Repository;
using IFSPLivraria.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace IFSPLivraria.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                    .EnableSensitiveDataLogging();
                //options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                //options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Editora>, BaseRepository<Editora>>();
            Services.AddScoped<IBaseRepository<Emprestimo>, BaseRepository<Emprestimo>>();
            Services.AddScoped<IBaseRepository<Livro>, BaseRepository<Livro>>();

            // Services
            Services.AddScoped<IBaseRepository<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseRepository<Editora>, BaseService<Editora>>();
            Services.AddScoped<IBaseRepository<Emprestimo>, BaseService<Emprestimo>>();
            Services.AddScoped<IBaseRepository<Livro>, BaseService<Livro>>();

            // Formulários


            Services.AddTransient<CadastroCliente, CadastroCliente>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroLivro, CadastroLivro>();
            Services.AddTransient<CadastroEditora, CadastroEditora>(
            Services.AddTransient<CadastroEmprestimo, CadastroEmprestimo>();
            );


            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                
                config.CreateMap<Cidade, CidadeModel>()
                    .ForMember(d => d.NomeEstado, d => d.MapFrom(x => $"{x.Nome}/{x.Estado}"));
                config.CreateMap<Cliente, ClienteModel>()
                    .ForMember(d => d.Cidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                    .ForMember(d => d.IdCidade, d => d.MapFrom(x => x.Cidade!.Id));
                config.CreateMap<Livro, Livro>();
                config.CreateMap<Emprestimo, Emprestimo>()
                .ForMember(d => d.Livro, d => d.MapFrom(x => x.Livro!.Titulo))
                .ForMember(d => d.IdLivro, d => d.MapFrom(x => x.Livro!.Id));
                    /*   config.CreateMap<Grupo, Grupo>();
                      config.CreateMap<Livro, LivroModel>()
                    .ForMember(d => d.Grupo, d => d.MapFrom(x => x.Grupo!.Nome))
                    .ForMember(d => d.IdGrupo, d => d.MapFrom(x => x.Grupo!.Id));*/
                config.CreateMap<Emprestimo, EmprestimoModel>()
                    .ForMember(d => d.IdCliente, d => d.MapFrom(x => x.Cliente!.Id))
                    .ForMember(d => d.Cliente, d => d.MapFrom(x => x.Cliente!.Nome))

                config.CreateMap<Emprestimo_Livro, Emprestimo_LivroModel>()
                    .ForMember(d => d.IdLivro, d => d.MapFrom(x => x.Livro!.Id))
                    .ForMember(d => d.Livro, d => d.MapFrom(x => x.Livro!.Titulo));

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
