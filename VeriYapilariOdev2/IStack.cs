using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev2
{
    interface IStack
    {
        void Push(object item);
        object Pop();
        object Peek();
        bool IsEmpty();
        int Top { get; set; }
        string getElements();
    }
}
