
using Castle.DynamicProxy;
using VitrineLuxury.Core.DataAccess;
using VitrineLuxury.Core.Service;
using VitrineLuxury.Core.UnitOfWorks;
using VitrineLuxury.Core.Utilities.Interceptors;
using VitrineLuxury.DataAccess.Concrete;
using VitrineLuxury.DataAccess.UnitOfWorks;
using VitrineLuxury.Service.Concrete;
using Autofac;
using Autofac.Extras.DynamicProxy;
using VitrineLuxury.Service.Abstract;

namespace VitrineLuxury.Service.DependencyResolvers.AutoFac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterGeneric(typeof(Repository<>))
                      .As(typeof(IRepository<>))
                      .InstancePerDependency();

            builder.RegisterGeneric(typeof(Service<>))
                      .As(typeof(IService<>))
                      .InstancePerDependency();



            builder.RegisterType<ProjectService>().As<IProjectService>().SingleInstance();
            builder.RegisterType<ProjectRepository>().As<IProjectRepository>().SingleInstance();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
