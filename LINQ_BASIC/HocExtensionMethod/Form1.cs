using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocExtensionMethod
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
            /* int n  = int.Parse(textBox1.Text);*/
            int n = textBox1.LayGiaTriInt();
            label1.Text = n.TinhTongTu1ToiN() +"";
            button1.ChangeColorRed();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text.NoiChuoi(textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien()
            {
                Birthday = new DateTime(1998,1,1),
                Ma = 1,
                Name ="Trần Thanh Bình"
            };
            int age  =  sinhVien.TinhTuoi();
            MessageBox.Show(age+"");
        }

        
    }
}
