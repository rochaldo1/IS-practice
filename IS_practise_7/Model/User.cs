using IS_practise_7.Model.Possibilities;
//using IS_practise_7.Model.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRYMODEL.Model.Fabric;
using TRYMODEL.Model.ForFabrics;

namespace IS_practise_7.Model
{
    public class User : IEntety
    {
        public Guid Id { get; }

        public string Login { get;  }

        public string Password { get; }

        public IChooseRole role { get; }

        public List<string> routesToRead { get; }

        public List<string> routesToChange { get; }

        public User(Guid Id, string Login, string Password, int role, List<string> routesToRead,List<string> routesToChange)
        {
            MyRoleFabric fabric = MyRole.GetMyRole(role);
            this.Id = Id;
            this.Login = Login;
            this.Password = Password;
            this.role = fabric.GetRole();
            this.routesToRead = routesToRead;
            this.routesToChange = routesToChange;
        }

        public string ReadFile(string path)
        {
            return role.ReadFile(path);
        }

        public string ChangeFile(string path, string text)
        {
            return role.ChangeFile(path, text);
        }
    }
}
