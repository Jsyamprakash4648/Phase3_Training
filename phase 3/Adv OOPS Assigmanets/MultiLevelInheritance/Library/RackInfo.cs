using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class RackInfo:DepartmentDetails
    {
        // Class RackInfo: DepartmentDetails
        // Properties: RackNumber, ColumnNumber
        public int RackNumber { get; set; }
        public int ColumnNumber{ get; set; }
    }
}