using IS_practise_7.Data.Users;
using IS_practise_7.Model;
using System.Security.Cryptography;
using System.Text;

namespace IS_practise_7.ViewModel.DataManager
{
    class DataManager : IDataManager
    {
        private readonly SerializeUsers serializeUsers;

        private User concreteUser = null;

        public User _concreteUser => concreteUser;
        public SerializeUsers SerializeUsers => serializeUsers;

        public DataManager(SerializeUsers serializeUsers)
        {
            this.serializeUsers = serializeUsers;
        }
        public static DataManager Instance(SerializeUsers serializeUsers) => new(serializeUsers);

        public async Task LoadAllUsersAsync()
        {
            await serializeUsers.LoadAsync();
        }

        public async Task SaveAllUsersAsync()
        {
            await serializeUsers.SaveAsync();
        }

        public bool TryAuthorization(string login, string password)
        {
            password = Convert.ToBase64String(MD5.HashData(Encoding.UTF8.GetBytes(password)));
            var tryFind = (from x in SerializeUsers.GetUsers()
                           where x.Login == login &&  x.Password == password
                           select x).FirstOrDefault();
            if(tryFind != null)
            {
                concreteUser = tryFind;
                return true;
            }
            return false;
        }
    }
}
