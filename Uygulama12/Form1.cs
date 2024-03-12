using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList sehirler = new ArrayList();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtSehirler.Text);
            Listele();
        }

        private void Listele()
        {
            listeSehirler.Items.Clear();
            foreach (string sehir in sehirler)
            {
                listeSehirler.Items.Add(sehir);
            }
        }

        private void btnAraEkle_Click(object sender, EventArgs e)
        {
            int indexNo = listeSehirler.SelectedIndex;
            sehirler.Insert(indexNo, txtSehirler.Text);
            Listele();
        }

        private void btnGunelle_Click(object sender, EventArgs e)
        {
            int indexNo = listeSehirler.SelectedIndex;
            sehirler[indexNo] = txtSehirler.Text;
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int indexNo = listeSehirler.SelectedIndex;
            sehirler.RemoveAt(indexNo);
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (sehirler.Contains(txtSehirler.Text))
            {
                labelDurum.Text = "Aranan Değer Bulundu.";
                listeSehirler.SelectedIndex = sehirler.IndexOf(txtSehirler.Text);
            }
            else
            {
                labelDurum.Text = "Aranan Değer Bulunamadı.";
            }
        }
    }
}
