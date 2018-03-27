using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilariOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        ZeminKatQueue zk = new ZeminKatQueue(15);
        BodrumKatStack bk = new BodrumKatStack(15);
        IkinciKatList ik = new IkinciKatList();

        private void btnArabaEkle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                Araba a = new Araba();
                a.ArabaRengi = "Yesil " + Convert.ToInt16(i + 1);
                Araba a1 = new Araba();
                a1.ArabaRengi = "Mavi " + Convert.ToInt16(i + 1);
                Araba a2 = new Araba();
                a2.ArabaRengi = "Beyaz " + Convert.ToInt16(i + 1);
                
                zk.ZeminKatArabaEkle(a);
                zk.Insert(a);
                bk.BodrumKatArabaEkle(a1);
                bk.Push(a1);
                ik.IkinciKatArabaEkle(a2);
                ik.InsertLast(a2);
            }
            MessageBox.Show("ZEMİN KATTAKİ ARABALAR"+zk.getElements()+ "\nBODRUM KATTAKİ ARABALAR" + bk.getElements()+"\nİKİNCİ KATTAKİ ARABALAR"+ik.getElements());
            btnArabaCikar.Visible = true;
        }
        
        private void btnArabaCikar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OTOPARKTAN ÇIKAN ARABA:" + zk.Remove());
            MessageBox.Show("ZEMİN KATTAKİ ARABALAR" + zk.getElements());
            MessageBox.Show("İKİNCİ KATTAN ÇIKAN ARABA:" + ik.Remove());
            MessageBox.Show("\nİKİNCİ KATTAKİ ARABALAR" + ik.getElements());
            
            MessageBox.Show("BODRUM KATTAN ÇIKAN ARABA:" + bk.Pop());
            zk.Insert(bk.Pop());
            MessageBox.Show("\nBODRUM KATTAKİ ARABALAR" + bk.getElements());
        }
    }
}
