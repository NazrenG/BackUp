
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackUp.Interface;
namespace BackUp.Class
{
    internal class Hdd : Storage_, ICapacity, ICopy, IData, IMemory
    {
        public Hdd(string mediaName, string model) : base(mediaName, model) { }

        public void Capacity()
        {
            Console.WriteLine("HDD capacity");
        }
        public void Copy()
        {
            Console.WriteLine("HDD copy");
        }
        public void FreeMemory()
        {
            Console.WriteLine("HDD free memory");
        }
        public void PrintDeviceİnfo()
        {
            Console.WriteLine("HDD print information ");
        }
    }
}
