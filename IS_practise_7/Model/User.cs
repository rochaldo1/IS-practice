using IS_practise_7.Model.Fabric;
using IS_practise_7.Model.ForFabrics;

namespace IS_practise_7.Model
{
    public class User : IEntety
    {
        public Guid Id { get; }
        public string Login { get; }
        public string Password { get; }
        public int Role_Id { get; set; }
        private IChooseRole Role { get; }
        public List<string> RoutesToRead { get; }
        public List<string> RoutesToChange { get; }

        public User(Guid Id, string Login, string Password, int Role_Id, List<string> RoutesToRead, List<string> RoutesToChange)
        {
            this.Id = Id;
            this.Login = Login;
            this.Password = Password;
            this.Role_Id = Role_Id;
            MyRoleFabric fabric = MyRole.GetMyRole(this.Role_Id);
            this.Role = fabric.GetRole();
            this.RoutesToRead = RoutesToRead;
            this.RoutesToChange = RoutesToChange;
        }

        public string ReadFile(string path)
        {
            return Role.ReadFile(path);
        }
        public string ChangeFile(string path, string text)
        {
            return Role.ChangeFile(path, text);
        }
    }
}
