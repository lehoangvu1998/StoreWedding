using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Model
{
    public class UserModel
    { 
        private String _Name;
        private String _Email;
        private String _Phone;
        private String _PWD;
        private bool _Piority;

         public bool Piority { get => _Piority; set => _Piority = value; }
         public string PWD { get => _PWD; set => _PWD = value; }
         public string Phone { get => _Phone; set => _Phone = value; }
         public string Email { get => _Email; set => _Email = value; }
        public string Name { get => _Name; set => _Name = value; }

        public UserModel() { }
        //Methods
        public UserModel(string name,  string email, string phone, string pass, bool pio)
        {
             Name = name;
            _Email = email;
            _Phone = phone;
            _PWD = pass;
            _Piority = pio;
        }
        public static class GlobalInfo
        {
            private static UserModel currentUser;

            public static UserModel CurrentUser
            {
                get { return currentUser; }
                set { currentUser = value; }
            }
        }
    }
}
