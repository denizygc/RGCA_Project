using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGCA
{
    class Locations
    {
        public string Location_ID { get; set; }
        public string Location_name { get; set; }
        public string Region_Name { get; set; }
        public string Building_Name { get; set; }
        public string Storey_Name { get; set; }

        public override string ToString()
        {
            return $"Location:{Location_ID}     Location Name:{Location_name}   Region Name:{Region_Name}" +
                $"  Building Name:{Building_Name}   Storey:{Storey_Name}";
        }
    }
}
