using System;
using System.Security;
using System.Security.Permissions;

namespace _3._2._5.Using_Code_Access_Permissions
{
    public class MainListing3X26
    {
        public MainListing3X26()
        {
            ImperativeCAS();
        }

        public static void ImperativeCAS()
        {
            FileIOPermission f = new FileIOPermission(PermissionState.None);
            f.AllLocalFiles = FileIOPermissionAccess.Read;
            try
            {
                f.Demand();
            }
            catch (SecurityException s)
            {
                Console.WriteLine(s.Message);
            }
        }


    }

}