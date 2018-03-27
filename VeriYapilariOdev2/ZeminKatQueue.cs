using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev2
{
    class ZeminKatQueue:IQueue
    {
        public List<Araba> Arabalar = new List<Araba>();
        private object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public ZeminKatQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
                throw new Exception("Queue dolu.....(overflow)");

            if (front == -1)
                front = 0;

            //Circular Code Değişikliği
            if (rear == size - 1)
            {
                rear = 0;
                Queue[rear] = o;
            }
            else
                Queue[++rear] = o;

            count++;
        }

        public void ZeminKatArabaEkle(Araba a)
        {
            Arabalar.Add(a);
        }
        
        public object Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Hata: Queue boş.....(underflow)");
            }
            //object temp = "";
            //temp = Peek();
            //string temp = (string)Peek();
            object temp = Queue[front];
            front++;
            if (front == size) front = 0;
            Arabalar.RemoveAt(Arabalar.Count-count);
            count--;
            //size--;
            //string x = temp.ToString();
            return temp;
        }

        public object Peek()
        {
            return Queue[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
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
