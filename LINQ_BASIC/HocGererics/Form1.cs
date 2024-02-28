using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocGererics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>();
        private void btnCreat_Click(object sender, EventArgs e)
        {
            dsInt.Clear();
            int n = int.Parse(txtInput.Text);
            Random rd = new Random();
            for (int i = 0; i < n; i++) { 
                int x = rd.Next(100);
                dsInt.Add(x);
            }
            /*dsInt.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });*/
            listGenerics.Items.Clear();
            foreach (int x in dsInt)
            {
                listGenerics.Items.Add(x);
            }
        }

        private void txtEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void listGenerics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listGenerics.SelectedIndex != -1)
            {
                txtEdit.Text= dsInt[listGenerics.SelectedIndex].ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dsInt[listGenerics.SelectedIndex] = int.Parse(txtEdit.Text);
            listGenerics.Items[listGenerics.SelectedIndex] = 
                dsInt[listGenerics.SelectedIndex]; 

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listGenerics.SelectedIndex != -1)
            {
                dsInt.RemoveAt(listGenerics.SelectedIndex);
                listGenerics.Items.Clear(); ;
                foreach (int x in dsInt)
                {
                    listGenerics.Items.Add(x);
                } 
            }
            else
            {
                MessageBox.Show("Error,Please Choose Item");
            }
        }
        Dictionary<int,String> dsCustomers = new Dictionary<int,String>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id =  int.Parse(txtID.Text);
            string name =  txtName.Text;
            dsCustomers.Add(id, name);
            txtID.Text = "";
            txtName.Text = "";
            ShowCustomer();
        }
         
        private void ShowCustomer()
        {
            listViewCustomer.Items.Clear();
            foreach (var item in dsCustomers)
            {
                ListViewItem listView = new ListViewItem(item.Key + "");
                listView.SubItems.Add(item.Value);
                listView.SubItems.Add(item.Value);
                listViewCustomer.Items.Add(listView);
            }
        }

        private void listViewCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCustomer.SelectedItems.Count == 0) return;
            ListViewItem lvi = listViewCustomer.SelectedItems[0]; 
            int id = int.Parse(lvi.SubItems[0].Text);
            string name = dsCustomers[id];
            txtID.Text = id+"";
            txtName.Text = name;
        }

       
         
        private void btnRemove_Click(object sender, EventArgs e)
        {
            dsCustomers.Remove(int.Parse(txtID.Text));
            ShowCustomer();
            txtID.Text = "";
            txtName.Text = "";
        }
    }
}
