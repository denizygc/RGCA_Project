using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGCA
{
    class BIMemployeGetir
    {
        public string BIN_ID{ get; set; }
        public string Garbage_Employee_ID { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Surname { get; set; }

        public override string ToString()
        {
            return $"BIN ID:{BIN_ID}     " +
                $"BIN Employee ID:{Garbage_Employee_ID}  " +
                $"Employee Name:{Employee_Name}     " +
                $"Employee Surname:{ Employee_Surname}";
        }
        
    }
}
