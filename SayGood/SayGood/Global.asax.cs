using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
//using SayGood.Infrastructure;

namespace SayGood
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
           RouteConfig.RegisterRoutes(RouteTable.Routes);

            //告诉mvc使用自定义d类来创建控制器对象
            //ControllerBuilder.Current.SetControllerFactory(new
            //    NinjectControllerFactory());
        }
    }
}
