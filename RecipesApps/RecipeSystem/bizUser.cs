using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizUser : bizObject<bizUser>
    {
        public bizUser() { }
        private int _userid;
        private string _userfirstname;
        private string _userlastname;
        private string _username;

        public int UserId
        {
            get => _userid;
            set
            {
                if (value != _userid)
                {
                    _userid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string UserFirstName
        {
            get => _userfirstname;
            set
            {
                if (value != _userfirstname)
                {
                    _userfirstname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string UserLastname
        {
            get => _userlastname;
            set
            {
                if (value != _userlastname)
                {
                    _userlastname= value;
                    InvokePropertyChanged();
                }
            }
        }

        public string UserName
        {
            get => _username;
            set
            {
                if (value != _username)
                {
                    _username = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
