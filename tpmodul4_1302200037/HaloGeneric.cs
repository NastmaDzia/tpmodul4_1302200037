using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302200037
{
    public class HaloGeneric
    {
        public static void SapaUser<T>(T user)
        {
            Console.WriteLine("Halo user " + user + "!");
        }
    }
}
