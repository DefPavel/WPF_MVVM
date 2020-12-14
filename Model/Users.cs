
namespace WPF_MVVM
{
    public class Users
    {
        private int _code;
        private string _status;
        private string _text;
        private string _login;
        private string _password;
        private string _nameRole;
        public int code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

        //----------- В случе успеха ----------------------//     

        public string login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string nameRole
        {
            get { return _nameRole; }
            set { _nameRole = value; }
        }
    }

}
