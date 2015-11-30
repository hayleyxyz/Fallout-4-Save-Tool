using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace f4lib.Utils
{
    public static class Buffer
    {
        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int memcmp(byte[] a, byte[] b, long count);

        public static bool compare(byte[] a, byte[] b) {
            return a.Length == b.Length && memcmp(a, b, a.Length) == 0;
        }

    }
}
