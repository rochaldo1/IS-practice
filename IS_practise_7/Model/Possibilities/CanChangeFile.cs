using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace IS_practise_7.Model.Possibilities
{
    public class CanChangeFile : IChangeFile
    {
        public string ChangeFile(string path,string text)
        {
            if (path == "NaN") return "В доступе отказано!";
            if (!(File.Exists(@path))) return "Файл не найден!";
            using var stream = File.Open(path, FileMode.Create);
            using var writer = new StreamWriter(stream);
            writer.Write(text);
            return "Успешно!";
        }
    }
}
