using IS_practise_7.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_practise_7.Model
{
    internal class TextFile : IEntety
    {
        private string _text;
        public Guid Id {  get; set; }

        public string Text {
            get => _text;
            set => _text = value;
        }
    }
}
