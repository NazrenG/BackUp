using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackUp.Interface;
namespace BackUp.Class
{
    internal class Flash : Storage_, ICapacity, ICopy, IData, IMemory
    {
        public Flash(string mediaName, string model) : base(mediaName, model) { }

        public void Capacity()
        {
            Console.WriteLine("Flash capacity");
        }
        public void Copy()
        {
            Console.WriteLine("Flash copy");
        }
        public void FreeMemory()
        {
            Console.WriteLine("Flash free memory");
        }
        public void PrintDeviceİnfo()
        {
            Console.WriteLine("Flash print information ");
        }
    }
}
