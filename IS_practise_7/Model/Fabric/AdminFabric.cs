using IS_practise_7.Model.Possibilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IS_practise_7.Model.ForFabrics;

namespace IS_practise_7.Model.Fabric
{
    internal class AdminFabric : MyRoleFabric
    {
        private readonly IReadTextFile _readTextFile;
        private readonly IChangeFile _changeFile;
        public AdminFabric(IReadTextFile readTextFile, IChangeFile changeFile)
        {
            _readTextFile = readTextFile;
            _changeFile = changeFile;
        }

        public override IChooseRole GetRole()
        {
            Admin member = new(_readTextFile, _changeFile);
            return member;
        }
    }
}
