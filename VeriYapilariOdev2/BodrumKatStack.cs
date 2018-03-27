using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev2
{
    class BodrumKatStack:IStack
    {
        public List<Araba> Arabalar = new List<Araba>();
        private object[] items;
        private int top = -1;

        public BodrumKatStack(int itemCount)
        {
            this.items = new object[itemCount];
        }
        public void Push(object item)
        {
            if (items.Length == Top + 1)
            {
                throw new Exception("Hata: Stack doldu.....(overflow)");
            }
            items[++Top] = item;
        }

        public void BodrumKatArabaEkle(Araba a)
        {
            Arabalar.Add(a);
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Hata: Stack boş.....(underflow)");
            }
            object temp = "";
            temp = Peek();
            Arabalar.RemoveAt(Arabalar.Count - 1);
            top--;
            return temp;
        }

        public object Peek()
        { 
            return items[Top] ;
        }

        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }

        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }
        public string getElements()
        {
            string temp = "";
            foreach (Araba a in Arabalar)//Listede gerekli arama yapıldı.
            {
                temp += "\nAraba Rengi:" + a.ArabaRengi;
            }

            return temp;
        }
    }
}
