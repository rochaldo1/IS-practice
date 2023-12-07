using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IS_practise_7.Model;


namespace IS_practise_7.Data
{
    public interface ISerializeBasic<T> where T : IEntety
    {
        bool Add(T obj);
        bool Delete(T obj);
        bool Update(T obj);

        bool Save();
        bool Load();
        Task<bool> SaveAsync();
        Task<bool> LoadAsync();
    }
}
