using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM
{
    /*
     *  ВЫЗЫВАЕМ ОТСЮДА ВСЕ ЗАПРОСЫ ЧЕРЕЗ API И ВЫВОДИМ ИХ ЧЕРЕЗ TASK - новый поток;

        Можно так же сделать с помощью  hhtpClient - но что-то там много подводных камней связанных с постоянным подключением,
        которые отключается в зависимости от времени в реестре Windows 
        
        За класс HttpWebRequest  - ВРОДЕ БЫ данной проблемой не страдает, по крайней мере я не нашел информацию связанную с этим
    */

    //Методы запросов
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    //Хелпер APi через которое будет отправляться запросы
    public class APIHelpers : IAPIHelpers
    {
        //Если вдруг придётся менять данные метода
        //По умолчанию в enum будет стоять 0 элемент,то есть GET
        public httpVerb HttpMethod { get; set; }

        #region Аутентификация пользователя
        public async Task<Users> Authenticate(string username, string password, string URL)
        {
            //------------------------- Создаём запрос -----------------------//
            string apiURL = ConfigurationManager.AppSettings["api"];
            var req = (HttpWebRequest)WebRequest.Create(apiURL + URL);
            req.Accept = "application/json";
            req.Method = HttpMethod.ToString();
            //---------------------------------------------------------------//

            //----------------- Авторизация через Midlleware ----------------
            string authHeaer = Aes256CbcEncrypter.
            Encrypt(username + "|" + password, "8UHjPgXZzXDgkhqV2QCnooyJyxUzfJrO");
            req.Headers.Add("AUTH", " " + authHeaer);
            req.Headers.Add("USER", " " + username);
 
           //------------- Получаем ответ запроса в новом потоке ------------
           Task<WebResponse> getResponseTask = req.GetResponseAsync();
           HttpWebResponse response = (HttpWebResponse)await getResponseTask;

            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(responseStream, Encoding.UTF8))
                {
                    string content = reader.ReadToEnd();
                    //Возвращаем json информацию которая пришла 
                    return JsonConvert.DeserializeObject<Users>(content);

                }
            }
           
        }
        #endregion

        #region Вернуть список всех общежитий
        public async Task<IEnumerable<Hostel>> GetHostel(string username, string password, string URL)
        {
            //------------------------- Создаём запрос -----------------------//
            string apiURL = ConfigurationManager.AppSettings["api"];
            var req = (HttpWebRequest)WebRequest.Create(apiURL + URL);
            req.Accept = "application/json";
            req.Method = HttpMethod.ToString();
            //---------------------------------------------------------------//

            //----------------- Авторизация через Midlleware ----------------
            string authHeaer = Aes256CbcEncrypter.
            Encrypt(username + "|" + password, "8UHjPgXZzXDgkhqV2QCnooyJyxUzfJrO");
            req.Headers.Add("AUTH", " " + authHeaer);
            req.Headers.Add("USER", " " + username);

            //------------- Получаем ответ запроса в новом потоке ------------
            Task<WebResponse> getResponseTask = req.GetResponseAsync();
            HttpWebResponse response = (HttpWebResponse)await getResponseTask;

            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(responseStream, Encoding.UTF8))
                {
                    string content = reader.ReadToEnd();
                    //Возвращаем json информацию которая пришла 
                    var json = JsonConvert.DeserializeObject<Hostel>(content);

                    return (IEnumerable<Hostel>)json;
                    // (ObservableCollection)host;

                }
            }
        }
        #endregion

        public IEnumerable<Hostel> GetHostelNew(string username, string password, string URL)
        {
            //------------------------- Создаём запрос -----------------------//
            string apiURL = ConfigurationManager.AppSettings["api"];
            var req = (HttpWebRequest)WebRequest.Create(apiURL + URL);
            req.Accept = "application/json";
            req.Method = HttpMethod.ToString();
            //---------------------------------------------------------------//

            //----------------- Авторизация через Midlleware ----------------
            string authHeaer = Aes256CbcEncrypter.
            Encrypt(username + "|" + password, "8UHjPgXZzXDgkhqV2QCnooyJyxUzfJrO");
            req.Headers.Add("AUTH", " " + authHeaer);
            req.Headers.Add("USER", " " + username);

            //------------- Получаем ответ запроса в новом потоке ------------
            WebResponse getResponseTask = req.GetResponse();
            HttpWebResponse response = (HttpWebResponse) getResponseTask;

            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(responseStream, Encoding.UTF8))
                {
                    string content = reader.ReadToEnd();
                    //Возвращаем json информацию которая пришла 



                    var json = JsonConvert.DeserializeObject<Hostel>(content);

                    return (IEnumerable<Hostel>)json;



                }
            }
        }
    }
}
