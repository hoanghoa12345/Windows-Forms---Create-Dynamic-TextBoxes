using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap2
{
    public partial class Form1 : Form
    {
        int[] array = new int[20];
        private TextBox[] txtArray;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int soPhanTu = int.Parse(txtSoPt.Text);
            lbTong.Text += SumArray(array, soPhanTu).ToString();
        }

        private void CreateTextBox (int soPhanTu)
        {
            #region CreateTxt
            /*int a = 1;

            for (int i = 0; i < soPhanTu; i++)
            {
                TextBox txt = new TextBox() {
                    Width = 30,
                    Top =  28,
                    Left = a * 34
                };
                a = a + 1;
                panel1.Controls.Add(txt);
            }
            TextBox[] textBox = new TextBox[20];
            for (int i = 0; i < soPhanTu; i++)
            {
                panel1.Controls.Add(textBox[i]);
                textBox[i].Text = i.ToString();
            }*/
            #endregion
            int a = 1;
            txtArray = new TextBox[soPhanTu];
            for(int i=0;i< soPhanTu;i++)
            {
                txtArray[i] = new TextBox()
                {
                    Width = 30,
                    Top = 28,
                    Left = a * 34
                };
                a++;
                panel1.Controls.Add(txtArray[i]);
            }
        }

        private int SumArray(int[] array, int soPhanTu)
        {
            int tong = 0;

            for(int i=0;i<soPhanTu;i++)
            {
                array[i] = int.Parse(txtArray[i].Text);
                tong = tong + array[i];
            }
            return tong;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int soPhanTu = int.Parse(txtSoPt.Text);
            CreateTextBox(soPhanTu);
        }
    }
}
