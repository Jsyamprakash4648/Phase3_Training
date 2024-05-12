using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OutSide;

namespace Inside
{
    public class First:Third
    {
        private int _privatenumber=10;
        public int PrivateOut { get{return _privatenumber;} }

        public int PublicNumber=20;

        protected int ProtectedNnumber=30;

        public int protectedinternalOut { get{return Internalprotected;}  }


    }
}