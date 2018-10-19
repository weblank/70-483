using System.Security.Permissions;

namespace _3._2._5.Using_Code_Access_Permissions
{
    public class MainListing3X25
    {
        public MainListing3X25()
        {
            DeclarativeCAS();
        }

        [FileIOPermission(SecurityAction.Demand, AllLocalFiles = FileIOPermissionAccess.Read)]
        public static void DeclarativeCAS()
        {
            // Method body
        }


    }

}