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
        int roleName = 0;
        public Guid Id { get; }

        public string Login { get;  }

        public string Password { get; }


        IChooseRole role { get; }

        public User(Guid Id, string Login, string Password, int role)
        {
            this.Id = Id;
            this.Login = Login;
            this.Password = Password;
            MyRoleFabric fabric = MyRole.GetMyRole(role);
            this.role = fabric.GetRole();
        }
       

        public string ReadFile(string path)
        {
            return role.ReadFile(path);
        }

        public string ChangeFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
