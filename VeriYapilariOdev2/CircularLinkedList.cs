using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev2
{
    interface CircularLinkedList
    {
        void InsertFirst(object /*o,int*/ value);
        void InsertLast(object /*o,int*/ value);
        object Remove();
        Boolean IsEmpty();
        string getElements();
    }
}
