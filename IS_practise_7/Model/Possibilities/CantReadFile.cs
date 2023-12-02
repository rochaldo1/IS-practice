using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_practise_7.Model.Possibilities
{
    public class CantReadFile : IReadTextFile
    {
        public string ReadFile(string path) => "У вас нет доступа к чтению файла!";
    }
}
