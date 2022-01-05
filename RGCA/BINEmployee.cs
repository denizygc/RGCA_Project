using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGCA
{
    class BINEmployee
    {
        public string Garbage_Employee_ID { get; set; }
        public string BIN_ID { get; set; }
        public string Employee_ID { get; set; }
        public DateTime Star_date { get; set; }

        public override string ToString()
        {
            return $"BIN Employee ID:{Garbage_Employee_ID}     " +
                $"BIN ID:{BIN_ID}  " +
                $"Employee ID:{Employee_ID}     " +
                $"Starting Date:{Star_date}";
        }
    }
}
