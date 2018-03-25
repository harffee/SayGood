using Ninject;
using SayGood.Abstract;
using SayGood.Concrete;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace SayGood.Infrastructure
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