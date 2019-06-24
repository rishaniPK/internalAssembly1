using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internalAssembly1
{
   public class childassembly
    {
        Class1 i = new Class1();
        int a = 1;
        int b = 3;
        public int add()
        {
            return i.x + i.y + a + b;
        }

    }
}
