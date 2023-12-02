using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_practise_7.Model
{
    public class User : IEntety
    {
        public Guid Id { get; }

        public string Login { get;  }

        public string Password { get; }

        public User(Guid Id, string Login, string Password)
        {
            this.Id = Id;
            this.Login = Login;
            this.Password = Password;
        }
    }
}
