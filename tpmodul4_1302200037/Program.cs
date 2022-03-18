using System;
using System.Collections;
using System.Collections.Generic;

namespace tpmodul4_1302200037
{
    public class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric.SapaUser("Nastma Dzia Ulhaque");
            DataGeneric<String> c = new DataGeneric<String>("13022000037"); ;
            c.PrintData();

        }
    }

}