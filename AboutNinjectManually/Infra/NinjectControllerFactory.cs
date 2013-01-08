using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using AboutNinjectManually.Models;
using Ninject;

namespace AboutNinjectManually.Infra
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private StandardKernel kernel;

        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IDrugDealer>().To<PabloEscobar>();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, System.Type controllerType)
        {
            return controllerType == null ? null : (IController) kernel.Get(controllerType);
        }
    }
}