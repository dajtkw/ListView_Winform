using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview_BTVNB3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void lsvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvShow.SelectedItems.Count > 0)
            {
                ListViewItem liv = lsvShow.SelectedItems[0];

                string lastName = liv.SubItems[0].Text;
                string firstName = liv.SubItems[1].Text;   
                string phone = liv.SubItems[2].Text;   

                txtFirstName.Text = firstName;
                txtLastName.Text = lastName;    
                txtPhone.Text = phone;  

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem liv = new ListViewItem("Ly");
            liv.SubItems.Add("Thi Bong");
            liv.SubItems.Add("23456");
            lsvShow.Items.Add(liv);

            ListViewItem liv1 = new ListViewItem("Nguyen");
            liv1.SubItems.Add("Van Chinh");
            liv1.SubItems.Add("4555");
            lsvShow.Items.Add(liv1);

            ListViewItem liv2 = new ListViewItem("Tran");
            liv2.SubItems.Add("Chanh Truc");
            liv2.SubItems.Add("123456");
            lsvShow.Items.Add(liv2);
        }

        private void btnDeleteName_Click(object sender, EventArgs e)
        {
            lsvShow.Items.RemoveAt(lsvShow.SelectedItems[0].Index);
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            int phone = int.Parse(txtPhone.Text);

            ListViewItem liv = new ListViewItem(lastName);
            liv.SubItems.Add(firstName);
            liv.SubItems.Add(phone.ToString());

            lsvShow.Items.Add(liv);

        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            if (lsvShow.SelectedItems.Count > 0)
            {
                string lastName = txtLastName.Text;
                string firstName = txtFirstName.Text;
                string phone = txtPhone.Text;

                ListViewItem liv = lsvShow.SelectedItems[0];
                liv.SubItems[0].Text = lastName;
                liv.SubItems[1].Text = firstName;
                liv.SubItems[2].Text = phone;
            }
        }
    }
}
