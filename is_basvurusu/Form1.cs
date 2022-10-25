using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_basvurusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "") 
            {
                int not1 = Convert.ToInt16(textBox1.Text);
                int not2 = Convert.ToInt16(textBox2.Text);
                int ort = (not1 + not2) / 2;

                string ort_ekran = Convert.ToString(ort);
                label4.Text=ort_ekran;

                if (ort<70)
                {
                    label6.Text = "Ortalamanız 70'in Altında Olduğu İçin İşe Alınmadınız";
                }
                else
                {
                    if (radioButton1.Checked==true)
                    {
                        label6.Text = "Ortalamanız 70 Üstü ve Bilgisayar Mühendisi Olduğunuz İçin İŞE ALINDINIZ";
                    }
                    else if (radioButton2.Checked==true)
                    {
                        label6.Text = "Ortalamanız 70 Üstü Fakat Endüstri Mühendisi OLduğunuz İçin İŞE ALINMADINIZ";
                    }
                    else if(radioButton3.Checked==true)
                    {
                        label6.Text = "Ortalamanız 70 Üstü FAkat Makina Mühendisi Oldugunuz İçin İŞE ALINMADINIZ";
                    }
                    else
                    {
                        label6.Text = "BÖLÜMÜNÜZÜ SEÇİNİZ";
                    }
                }   
            }
            else
            {
                label6.Text = "Notlarınızı Giriniz";
            }
        }   
    }           
}
