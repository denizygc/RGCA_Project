using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGCA
{
    class BINGetir
    {
        public string BIN_ID { get; set; }
        public string Garbage_Type_Name { get; set; }
        public string Garbage_Type_Definition { get; set; }
        public string Trash_Type_ID { get; set; }
        public string Waste_DP_ID { get; set; }
        public string Location_ID { get; set; }


        public override string ToString()
        {
            return $"BIN ID:{BIN_ID}    Garbage Type:{Garbage_Type_Name} " +
                $"  Definition:{Garbage_Type_Definition}    Trash Type:{Trash_Type_ID} " +
                $"  Waste ID:{Waste_DP_ID}  LOcation ID:{Location_ID}  ";
        }
    }
}
