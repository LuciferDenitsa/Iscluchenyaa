using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iscluchenyaa
{
    internal class MyExcep : Exception
    {
        public MyExcep(string message) : base(message) { }
    }
}
