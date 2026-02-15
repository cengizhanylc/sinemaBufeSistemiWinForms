using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_büfe_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, misir_adet, su_adet, cay_adet, bilet_adet, tutar;
            misir = 40;
            su = 5;
            cay = 15;
            bilet = 100;
            //misir_adet =Convert.ToInt32(textBox_misir.Text);
            //su_adet =Convert.ToInt32(textBox_su.Text);
            //cay_adet =Convert.ToInt32(textBox_cay.Text);
            //bilet_adet =Convert.ToInt32(textBox_bilet.Text);

            if (!string.IsNullOrEmpty(textBox_misir.Text))
                misir_adet = Convert.ToInt32(textBox_misir.Text);
            else
                misir_adet = 0;

            if (!string.IsNullOrEmpty(textBox_su.Text))
                su_adet = Convert.ToInt32(textBox_su.Text);
            else
                su_adet = 0;

            if (!string.IsNullOrEmpty(textBox_cay.Text))
                cay_adet = Convert.ToInt32(textBox_cay.Text);
            else
                cay_adet = 0;

            if (!string.IsNullOrEmpty(textBox_bilet.Text))
                bilet_adet = Convert.ToInt32(textBox_bilet.Text);
            else
                bilet_adet = 0;

            tutar = (misir_adet*misir) + (su_adet*su_adet) + (cay_adet*cay) + (bilet_adet*bilet);
            label_tutar.Text = tutar.ToString(tutar + "TL");
  
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
