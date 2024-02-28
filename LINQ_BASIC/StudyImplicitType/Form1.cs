using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyImplicitType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*var sanPham = new SanPham()
            {
                Ma = int.Parse(txtID.Text),
                Tem =  txtName.Text
            };
            lstSanPham.Items.Add(sanPham.Ma+" - "+sanPham.Tem);*/
            var sanPham = new 
            {
                Ma = int.Parse(txtID.Text),
                Tem = txtName.Text
            };
            lstSanPham.Items.Add(sanPham.Ma + " - " + sanPham.Tem);
        }
    }
}
