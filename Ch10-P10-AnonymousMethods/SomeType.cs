using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_P10_AnonymousMethods
{
    class SomeType
    {
        public delegate void MyDelegate();

        public event MyDelegate SomeEvent;

    }
}
