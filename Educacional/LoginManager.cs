using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacional
{
    class LoginManager
    {
        public static ObservableCollection<User> users = new ObservableCollection<User>();

        public static User currentUser = null;
    }
}
