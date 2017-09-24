using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using System.Web.Routing;
using System.ComponentModel;
using EmricServ.Blog.Repository.Interfaces;
using EmricServ.Blog.Repository;

namespace mricServ.Blog.WebUI.Infrastracture
{
    /// <summary>
    /// Unity factory for type initialization.
    /// 
    /// Always refer in Applicatn_Start in global.asax
    /// </summary>
    public class UnityControllerFactory : DefaultControllerFactory
    {
        private readonly IUnityContainer _container;

        public UnityControllerFactory()
        {
            _container = new UnityContainer();
            RegisterTypes();
        }

        private void RegisterTypes()
        {
            //RegisterEventArgs Types here
            // e.g._container.RegisterType<IFileService, FileService>()
            //
            _container.RegisterType<IUnitOfWork, UnitOfWork>();

        }

        public UnityControllerFactory(IUnityContainer container)
        {
            _container = container;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType != null)
            {
                return _container.Resolve(controllerType) as IController;
            }
            return base.GetControllerInstance(requestContext, controllerType);
        }
    }

}