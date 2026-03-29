using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL5_103022400043
{
    internal class DataGeneric<T>
    {
        public T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
}
