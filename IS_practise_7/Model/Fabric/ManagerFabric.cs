using IS_practise_7.Model.Possibilities;
using IS_practise_7.Model.ForFabrics;

namespace IS_practise_7.Model.Fabric
{
    internal class ManagerFabric : MyRoleFabric
    {
        private readonly IReadTextFile _readTextFile;
        private readonly IChangeFile _changeFile;
        public ManagerFabric(IReadTextFile readTextFile, IChangeFile changeFile)
        {
            _readTextFile = readTextFile;
            _changeFile = changeFile;
        }
        public override IChooseRole GetRole()
        {
            Manager member = new (_readTextFile, _changeFile);
            return member;
            
        }
    }
}
