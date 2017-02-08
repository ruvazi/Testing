using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TestingFirstAssignment
{
    class ValidInteger
    {
        public bool VI(int a)
        {
            if (a > 0) { return true;}
            else { return false;}
        }

    }
}
