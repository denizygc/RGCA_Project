using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGCA
{
    internal class Garbage
    {
        public string BIN_ID {get; set;}
        public string BIN_Name {get; set;}
        public string Garbage_Type_ID {get; set;}
        public string Trash_Type_ID{get; set;}
        public string Location_ID{get; set;}
        public string Waste_DP_ID { get; set; }


        public override string ToString()
        {
            return $"BIN ID:{BIN_ID}    BIN Name:{BIN_Name}     Garbage Type ID:{Garbage_Type_ID}   " +
                $"Trash Type ID:{Trash_Type_ID}     Location ID:{Location_ID}     Waste ID:{Waste_DP_ID}   ";
        }

    }
}
