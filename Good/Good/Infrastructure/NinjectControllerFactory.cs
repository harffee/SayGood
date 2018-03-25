using Ninject;
using Praise2017.Abstract;
using Praise2017.Concrete;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Praise2017.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext
            requestContext, Type controllerType)
        {

            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IAccountRepo>().To<EFAccountRepo>();



        }
    }
}