using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackUp.Interface;
namespace BackUp.Class
{
    internal class Dvd : Storage_, ICapacity,ICopy,IData,IMemory
    {
        public Dvd(string mediaName, string model) : base(mediaName, model) { }

        public void Capacity()
        {
            Console.WriteLine("DVD capacity");
        }
        public void Copy()
        {
            Console.WriteLine("DVD copy");
        }
        public void FreeMemory()
        {
            Console.WriteLine("DVD free memory");
        }
        public void PrintDeviceİnfo()
        {
            Console.WriteLine("DVD print information ");
        }
    }
}
