using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPF_MVVM
{
    //реализуем интерфейс (класса APIHelpers - метода Request)
    public interface IAPIHelpers
    {
        httpVerb HttpMethod { get; set; }

        Task<Users> Authenticate(string username, string password, string URL);

        Task<IEnumerable<Hostel>> GetHostel(string username, string password, string URL);

        IEnumerable<Hostel> GetHostelNew(string username, string password, string URL);
    }
}