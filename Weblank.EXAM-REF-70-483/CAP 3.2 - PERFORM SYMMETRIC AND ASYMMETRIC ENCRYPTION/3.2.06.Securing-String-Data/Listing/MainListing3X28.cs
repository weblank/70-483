using System;
using System.Runtime.InteropServices;
using System.Security;

namespace _3._2._6.Securing_String_Data
{
    public class MainListing3X28
    {
        public MainListing3X28()
        {
            SecureString ss = new SecureString();
            ss.AppendChar('x');
            ss.AppendChar('p');
            ss.AppendChar('t');
            ss.AppendChar('o');
            ConvertToUnsecureString(ss);
        }

        private static void ConvertToUnsecureString(SecureString securePassword)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                Console.WriteLine(Marshal.PtrToStringUni(unmanagedString));
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

    }

}