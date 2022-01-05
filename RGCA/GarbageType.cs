using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGCA
{

    internal class GarbageType
    {
        public string Garbage_Type_ID { get; set; }
        public string Garbage_Type_Name { get; set; }
        public string Garbage_Type_Definition { get; set; }

        public override string ToString()
        {
            return $"Garbage Type:{Garbage_Type_ID}     Garbage Name:{Garbage_Type_Name}    Garbage Definition:{Garbage_Type_Definition}";
        }

    }
}
