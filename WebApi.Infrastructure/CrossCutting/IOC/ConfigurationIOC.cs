using AutoMapper;
using Autofac;
using WebApi.Application;
using WebApi.Domain.Services;
using WebApi.Application.Interface;
using WebApi.Domain.Core.Interface.Services;
using WebApi.Domain.Core.Interface.Repositories;
using WebApi.Infrastructure.Data.Repository;
using WebApi.Application.Mappers;

namespace WebApi.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServiceClient>().As<IApplicationServiceClient>();
            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();
            builder.RegisterType<ServiceClient>().As<IServiceClient>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<RepositoryClient>().As<IRepositoryClient>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingClient());
                cfg.AddProfile(new ModelToDtoMappingClient());
                cfg.AddProfile(new DtoToModelMappingProduct());
                cfg.AddProfile(new ModelToDtoMappingProduct());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }
    }
}