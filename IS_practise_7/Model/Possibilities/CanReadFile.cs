using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_practise_7.Model.Possibilities
{
    public class CanReadFile : IReadTextFile
    {

        public string ReadFile(string path)
        {
            if (path == "NaN") return "В Доступе отказано!";
            if (!(File.Exists(@path))) return "Файл не найден!";
            using var stream = File.Open(path, FileMode.Open);
            using var reader = new StreamReader(stream);
            string text = reader.ReadToEnd();
            if (string.IsNullOrEmpty(text)) return "Пусто!";
            return text;
        }
        //public async Task ReadTextFileAsync() { return await Task.Run(ReadFile(string path); }


    }
}
