using System;
using TP_MODUL5_103022400043;

namespace TP_MODUL5_103022400043
{
    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser<string>("Ariz");

            DataGeneric<string> data = new DataGeneric<string>("103022400043");
            data.PrintData();
        }
    }
}