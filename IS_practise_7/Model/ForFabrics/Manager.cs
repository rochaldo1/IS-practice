using IS_practise_7.Model.Possibilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_practise_7.Model.ForFabrics
{
    public class Manager : IChooseRole
    {
        private IReadTextFile _readTextFile;
        private IChangeFile _changeFile;

        public Manager(IReadTextFile readTextFile, IChangeFile changeFile)
        {
            _readTextFile = readTextFile;
            _changeFile = changeFile;
        }

        public string ChangeFile(string path)
        {
            throw new NotImplementedException();
        }

        public string ReadFile(string path)
        {
            return _readTextFile.ReadFile(path);
        }
    }

}
