using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_practise_7.Model.Possibilities
{
    public class CanReadTextFile : IReadTextFile
    {
        
        public string ReadFile(string path)
        {
            using var stream = File.Open(path, FileMode.Open);
            using var reader = new StreamReader(stream);
            string text = reader.ReadToEnd();
            if (string.IsNullOrEmpty(text)) return "Пусто!";
            return text;
        }
        //public async Task ReadTextFileAsync() { return await Task.Run(ReadFile(string path); }

       
    }
}
