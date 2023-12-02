using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IS_practise_7.Model.Possibilities;

namespace TRYMODEL.Model.Fabric
{
    internal static class MyRole 
    {
        public static MyRoleFabric GetMyRole(int roleName) => roleName switch
        {
            0 => new AdminFabric(new CanReadFile(), new CanChangeFile()),
            1 => new ManagerFabric(new CanReadFile(), new CantChangeFile()),
            2 => new ManagerFabric(new CantReadFile(), new CantChangeFile()),
            _ => null
        };

    }
}
