using q_math;
using System.Runtime.InteropServices;

namespace Hello
{
    class HelloClass
    {
        //[DllImport("add.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        //private static extern int Sum();

        q_mathclass qc = new q_mathclass();

        public void HelloWorld()
        {
            float y = qc.Q_rsqrt(2.0F);
          // Sum();
          Console.WriteLine(y);
        }
    }
}