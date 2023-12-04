using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IS_practise_7.DataManager;
using IS_practise_7.Model;
using System.Text.Json;
using System.Collections;
using System.IO;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace IS_practise_7.DataManager.Users
{
    public class SerializeUsers : ISerializeBasic<User>
    {
        protected List<User> _users = new ();

        private string path = string.Empty;
        public SerializeUsers(string path)
        {
            this.path = path;
            if (string.IsNullOrEmpty(this.path))
                throw new System.Exception("Путь сохранения не задан или задан неверно!");
        }

        public bool Add(User user)
        {
            if (user == null || _users.Contains(user)) return false;
            var checkSimilary = from selectUser in _users
                    where (user.Id == selectUser.Id || user.Login == selectUser.Login)
                    select selectUser;
            if (checkSimilary.Count() != 0) return false;
            _users.Add(user);
            return true;
        }

        public bool Delete(User user)
        {
            if (_users == null) return false;
            if (!(_users.Contains(user))) return false;
            _users.Remove(user);
            return true;
        }
        public bool Update(User user)
        {
            for(int i=0; i<_users.Count; i++)
            {
                if (_users[i]== user)
                {
                    _users[i] = user;
                    return true;
                }
            }
            return false;
        }

        public List<User> GetUsers() => _users;

        public bool Save()
        {
            if (_users == null) return false;
            using var stream = File.Open(path, FileMode.Create);
            using var writer = new StreamWriter(stream);
            var options = new JsonSerializerOptions { WriteIndented = true };
            string saveJson = JsonSerializer.Serialize(_users, options);
            writer.Write(saveJson);
            return true;
        }

        public async Task<bool> SaveAsync()
        {
            return await Task.Run(Save);
        }
        public bool Load()
        {
            using var stream = File.Open(path,FileMode.Open);
            using var reader = new StreamReader(stream);
            string parseJson = reader.ReadToEnd();
            if (parseJson == null) return false;
            //_users = JsonSerializer.Deserialize<List<User>>(parseJson);
            List<User> list = JsonSerializer.Deserialize<List<User>>(parseJson);
            return true;
        }

        public async Task<bool> LoadAsync()
        {
            return await Task.Run(Load);
        }
        
    }
}
