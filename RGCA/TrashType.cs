using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGCA
{
    class TrashType
    {
        public string Trash_Type_ID { get; set; }
        public string Trash_Type_Name { get; set; }
        public string Capacity_Amount { get; set; }

        public override string ToString()
        {
            return $"Trash Type:{Trash_Type_ID}     Trash Type{Trash_Type_Name}     Capacity:{Capacity_Amount}";
        }
    }
}
