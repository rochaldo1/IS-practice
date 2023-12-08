using IS_practise_7.Model.Possibilities;

namespace IS_practise_7.Model.Fabric
{
    internal static class MyRole 
    {
        public static MyRoleFabric GetMyRole(int roleName) => roleName switch
        {
            0 => new AdminFabric(new CanReadFile(), new CanChangeFile()),
            1 => new ManagerFabric(new CanReadFile(), new CanChangeFile()),
            2 => new ManagerFabric(new CanReadFile(), new CantChangeFile()),
            3 => new ManagerFabric(new CantReadFile(), new CantChangeFile()),
            _ => null
        };

    }
}
