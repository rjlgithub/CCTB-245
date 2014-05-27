using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
{
    //Class Computer inherits from Class Product
    public class Computer : Product
    {
        public string CPU { get; set; }
        public string OperatingSystem { get; set; }
    }
}
