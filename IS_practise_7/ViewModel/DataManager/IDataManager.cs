using IS_practise_7.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IS_practise_7.Data.Users;

namespace IS_practise_7.ViewModel.DataManager
{
    public interface IDataManager
    {
        public User _concreteUser {  get; }
        public SerializeUsers SerializeUsers { get; }

        public Task SaveAllUsersAsync();
        public Task LoadAllUsersAsync();

        public bool TryAuthorization(string login, string password);
    }
}
