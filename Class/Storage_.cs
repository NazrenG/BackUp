using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackUp.Interface;
namespace BackUp.Class
{

    abstract class Storage_
    {
        public string? MediaName { get; set; }
        public string? Model { get; set; }
        public Storage_()
        {
            MediaName = null;
            Model = null;
        }

        protected Storage_(string? mediaName, string? model)
        {
            MediaName = mediaName;
            Model = model;
        }
    }
}
