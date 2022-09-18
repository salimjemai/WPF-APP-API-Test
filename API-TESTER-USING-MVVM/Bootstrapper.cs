using API_TESTER_USING_MVVM.ViewModels;
using API_TESTER_USING_MVVM.Models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using API_TESTER_USING_MVVM.Models.UserManagement;

namespace API_TESTER_USING_MVVM
{
    public class Bootstrapper : BootstrapperBase
    {

        private SimpleContainer _container = new SimpleContainer(); 

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            // instantiate the container that returns itself
            _container.Instance(_container);

            _container
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<IEventAggregator, EventAggregator>();

            // one instance per request
            _container.PerRequest<ILoginModel, LoginModel>();
            _container.PerRequest<IUserModel, UserModel>();

            // This is grabbing all the View Models and register them 
            GetType().Assembly.GetTypes()
                .Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(viewModelType => _container
                .RegisterPerRequest(viewModelType, viewModelType.ToString(), viewModelType));
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

    }
}
