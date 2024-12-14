using System;
using System.Runtime.InteropServices;

namespace Hello
{
    class HelloClass
    {
        [DllImport("add.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int Sum();

        public void HelloWorld()
        {
            
           Sum();
        }
    }
}