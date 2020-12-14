using Caliburn.Micro;

namespace WPF_MVVM
{
    public class ShellViewModel: Conductor<object>, IHandle<LogOnEvent>
    {

        //ГЛАВНОЕ МОДАЛЬНОЕ ОКНО на котором будут отображаться все USERCONTROL из View

        private IEventAggregator _events;
        private MainViewModel _mainVM;
        private SimpleContainer _container;

        //Запускаем через ShellView - UserControl LoginView
       public ShellViewModel( IEventAggregator events, MainViewModel mainVM , SimpleContainer container)
       {
          
            _events = events;
            _mainVM = mainVM;
            _container = container;
            //Запускаем loginView
            ActivateItem(_container.GetInstance<LoginViewModel>());

            _events.Subscribe(this);

           

       }
        public void Handle(LogOnEvent message)
        {
            ActivateItem(_mainVM);
        }
    }
}