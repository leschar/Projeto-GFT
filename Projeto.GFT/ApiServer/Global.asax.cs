using ApiServer.Domain.Interfaces;
using ApiServer.Domain.Services;
using ApiServer.Infra.Repositories;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace ApiServer
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RegisterWebApi();
            RegisterDependencyInjection();
        }

        private void RegisterWebApi()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        private void RegisterDependencyInjection()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            // Register your types using the scoped lifestyle
            container.Register<IInvestimentoService, InvestimentoServices>(Lifestyle.Scoped);
            container.Register<ICDIRepository, CDIRepository>(Lifestyle.Scoped);
            container.Register<ITBRepository, TBRepository>(Lifestyle.Scoped);
            container.Register<IImpostoRepository, ImpostoRepository>(Lifestyle.Scoped);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }

    }
}
