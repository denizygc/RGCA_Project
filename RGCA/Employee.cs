using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGCA
{
    class Employee
    {
        public string Employee_ID { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Surname { get; set; }
        public DateTime Giris_Tarihi { get; set; }

        public override string ToString()
        {
            return $"Employee ID:{Employee_ID}  " +
                $"Employee Name:{Employee_Name}     " +
                $"Employee_Surname:{Employee_Surname}   " +
                $"Employee Starting Date:{Giris_Tarihi}";
        }
    }
}

