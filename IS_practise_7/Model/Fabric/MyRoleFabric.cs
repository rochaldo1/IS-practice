using IS_practise_7.Model.Possibilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRYMODEL.Model.ForFabrics;

namespace TRYMODEL.Model.Fabric
{
    internal abstract class MyRoleFabric
    {
        public abstract IChooseRole GetRole();
        
    }
}
