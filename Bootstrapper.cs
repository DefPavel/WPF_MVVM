using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace WPF_MVVM
{

    //Через данный класс мы поднимаем StartUp приложение смотреть в App.xaml
    class Bootstrapper: BootstrapperBase
    {
        //Данный класс запускает Shell - (View)

        #region Контейнер который переопределяет класс (Как он работает - не знаю,но он нужен)
        private SimpleContainer _container = new SimpleContainer();

        protected override void Configure()
        {
            _container.Instance(_container);
            //Добавляем в контейнеры все наши интерфейсы и их реализацию
            _container
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<IEventAggregator, EventAggregator>()
                .Singleton<IAPIHelpers, APIHelpers>();


            GetType().Assembly.GetTypes()
                .Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(ViewModelType => _container.RegisterPerRequest(
                    ViewModelType, ViewModelType.ToString(), ViewModelType));

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
        #endregion


        #region Основное при запуске Shell через Bootstrapper
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
             DisplayRootViewFor<ShellViewModel>(); //Запуск на прямую!!!
            //base.OnStartup(sender, e);
        }
        #endregion

      
    }
}
