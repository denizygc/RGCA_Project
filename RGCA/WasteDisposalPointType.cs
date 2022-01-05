using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGCA
{
    class WasteDisposalPointType

    {
        public string Waste_DP_ID { get; set; }
        public string Garbage_Type_Name { get; set; }
        public string Capacity_Amount { get; set; }
        public string Region_Name { get; set; }
   

        public override string ToString()
        {
            return $"Waste ID:{Waste_DP_ID}     Garbage Type:{Garbage_Type_Name}" +
                $"  Capacity:{Capacity_Amount}  Region Name:{Region_Name}";
        }
    }
}
