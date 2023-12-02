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

namespace IS_practise_7.DataManager.Users
{
    public class SerializeUsers /*: ISerializeBasic<User>*/
    {
        //private UsersList _users = new();
        //private string path = string.Empty; 
        //public SerializeUsers(string path)
        //{
        //    this.path = path;
        //}

        //public bool Add(User obj)
        //{
        //    if (_users.users.Contains(obj) || obj == null)
        //        return false;
        //    _users.users.Add(obj);
        //    return true;
        //}

        //public bool Remove(User obj)
        //{
        //    if(_users.users.Contains(obj) )
        //    {
        //        _users.users.Remove(obj);
        //        return true;
        //    }
        //    return false;
        //}

       
        //public bool Update(User obj)
        //{
        //    for (int i=0; i< _users.users.Count; i++)
        //    {
        //        if (_users.users[i] == obj)
        //        {
        //            _users.users[i] = obj;
        //            return true;
        //        }

        //    }
        //    return false;
        //}
        //public bool Load()
        //{
        //    using var stream = File.Open(path, FileMode.Open);
        //    using var reader = new StreamReader(stream);
        //    string text = reader.ReadToEnd();

        //    if (string.IsNullOrEmpty(text)) return false;

        //    _users.users = JsonSerializer.Deserialize<List<User>>(text);

        //    return true;
        //}

        //public async Task<bool> LoadAsync()
        //{
        //    return await Task.Run(Load);
        //}
        //public bool Save()
        //{
        //    if (_users.users.Count == 0) return false;  

        //    using var stream = File.Open(path, FileMode.Create);
        //    using var writer = new StreamWriter(stream);
        //    var options = new JsonSerializerOptions { WriteIndented = true };
        //    string text = JsonSerializer.Serialize(_users.users, options);
        //    writer.Write(text);
        //    return true;
        //}

        //public async Task<bool> SaveAsync()
        //{
        //    return await Task.Run(Save);
        //}

  
    }
}
