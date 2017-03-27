using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeoHotelManagement.Model;
using LeoHotelManagement.BLL;
using System.Windows.Forms;

namespace LeoHotelManagement.UI
{
    public partial class Form1 : Form
    {
        CustomerManager cm = new CustomerManager();
        Customer cus = new Customer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void LoadInfo()
        {
            showroom.AutoGenerateColumns = false;
            var customerlist = cm.QueryList(0, 0, null, null).ToList();
            showroom.DataSource = customerlist;
            for (int i = 0; i < customerlist.Count; i++)
            {
                showroom.Rows[i].Cells[1].Value = customerlist[i].cGender == true ? "Male" : "Female";
            }
            showroom.SelectedRows[0].Selected = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cus.cName = txtname.Text;
            cus.cGender = txtMale.Checked ? true : false;
            cus.cPhone = txtphone.Text;
            cus.cIdNo = txtcustomerid.Text;
            cus.cRemark = txtremark.Text;
            cm.Insert(cus);
            LoadInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.CustomerId = Convert.ToInt32(showroom.SelectedRows[0].Cells[5].Value);
            c.cName = txtnameedit.Text;
            c.cIdNo = txtIDnumedit.Text;
            c.cPhone = txtphoneedit.Text;
            c.cRemark = txtremarkedit.Text;
            c.cGender = txtmaleedit.Checked ? true : false;
            cm.Update(c);
            LoadInfo();
            clear();
        }

        private void showroom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnameedit.Text = showroom.SelectedRows[0].Cells[0].Value.ToString();
            txtmaleedit.Checked = showroom.SelectedRows[0].Cells[1].Value.ToString() == "Male" ? true : false;
            txtfemaleedit.Checked = showroom.SelectedRows[0].Cells[1].Value.ToString() == "Female" ? true : false;
            txtIDnumedit.Text = showroom.SelectedRows[0].Cells[2].Value.ToString();
            txtphoneedit.Text = showroom.SelectedRows[0].Cells[3].Value.ToString();
            txtremarkedit.Text = showroom.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void clear()
        {
            txtnameedit.Text = "";
            txtmaleedit.Checked = false;
            txtfemaleedit.Checked = false;
            txtIDnumedit.Text = "";
            txtphoneedit.Text = "";
            txtremarkedit.Text = "";
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (showroom.SelectedRows.Count > 0)
            {
                var c = cm.QuerySingle(Convert.ToInt32(showroom.SelectedRows[0].Cells[5].Value));
                if (c != null)
                    cm.Delete(Convert.ToInt32(showroom.SelectedRows[0].Cells[5].Value));
                LoadInfo();
                return;
            }
            MessageBox.Show("pick one!!!!");
            return;
        }
    }
}
