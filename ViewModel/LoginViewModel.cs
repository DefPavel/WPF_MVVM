using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPF_MVVM
{
   public class LoginViewModel : Screen
   {      
        //Авторизация 

        private readonly IAPIHelpers _aPIHelpers;

        private IEventAggregator _events;

        private string _UserName;

        private string _Password;

        private string _errorMessage;

        // Конструктор для инициализации Interface APIHelpers 
        // и чтобы мы могли пользоваться всеми методами реализованные в данном интерфейсе 
        public LoginViewModel(IAPIHelpers aPIHelpers, IEventAggregator events)
        {
            //Используем методы данного интерфейса
            _aPIHelpers = aPIHelpers;

            //Используем события данного интерфейса
            _events = events;
        }
        public string UserName
        {
            get { return _UserName; }
            set 
            {
                _UserName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLoginIn);
            }
        }
        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLoginIn);
            }
        }
        // Свойство блокировки Кнопки до тех пор пока не будут заполнены UserName и Password
        public bool CanLoginIn
        {
            get
            {
                return !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password);
            }
        }
        //Свойство TextBlock Error  - показывать при ошибки
        public bool IsErrorVisible
        {
            get 
            {
                return !string.IsNullOrEmpty(ErrorMessage);
            }
         
        }
        // Сообщение об ошибки 
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set 
            {
                _errorMessage = value;
                NotifyOfPropertyChange(() => IsErrorVisible);
                NotifyOfPropertyChange(() => ErrorMessage);
            }
        }
        // Асинхронный метод для Авторизации при нажатии на кнопку 
        // Где мы передаём значение из TextBox и путь URL
        public async Task LoginIn()
        {
            ErrorMessage = string.Empty;
            try
            {
                Users result = await _aPIHelpers.Authenticate(UserName, Password, "/auth.json");

               switch (result.code)
                {
                    case 200:
                        {
                            //Вызываем через событие класс LogOnEvent
                            _events.PublishOnUIThread(new LogOnEvent());
                        }
                        break;
                    case 401:
                        {
                            ErrorMessage = result.text;
                            
                        }
                        break;
                    case 13:
                        {
                            ErrorMessage = result.text;
                           
                        }
                        break;
                }
            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;
            }
        }

   }
}
