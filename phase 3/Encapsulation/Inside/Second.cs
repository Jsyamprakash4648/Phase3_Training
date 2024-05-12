using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OutSide;

namespace Inside
{
    public class Second:First
    {

        public int ProtectedNnumberOut { get{return ProtectedNnumber;}}
        protected internal  int internalProtected=50;
        
    }
}