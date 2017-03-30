using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeoHotelManagement.BLL;
using LeoHotelManagement.Model;
namespace LeoHotelManagement.UI
{
    public partial class Main_RoomType : Form
    {
        RoomTypeManager rtm = new RoomTypeManager();
        public Main_RoomType()
        {
            InitializeComponent();
        }
        //for opening the panel
        private void toolstripadd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }
        //load the list
        private void Main_RoomType_Load(object sender, EventArgs e)
        {
            LoadList("normal");
        }
        /// <summary>
        /// load list
        /// </summary>
        /// <param name="type"></param>
        private void LoadList(string type)
        {
            dataGridView1.AutoGenerateColumns = false;
            switch (type)
            {
                case "normal":
                    var list = rtm.QueryList(0, 0, new { rTypeIsDel = false }, null);
                    dataGridView1.DataSource = list.ToList();
                    dataGridView1.SelectedRows[0].Selected = false;
                    break;
                case "bin":
                    var list1 = rtm.QueryList(0, 0, new { rTypeIsDel = true }, null);
                    dataGridView1.DataSource = list1.ToList();
                    dataGridView1.SelectedRows[0].Selected = false;
                    break;
            }


        }
        //close panel by clicking cancel
        private void txtcancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        //submit button
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Model.RoomType rt = new Model.RoomType();
            rt.rTypeName = txtroomtype.Text;
            try
            {
                rt.rTypePrice = Convert.ToDecimal(txtprice.Text);
            }
            catch
            {
                MessageBox.Show("input right number");
                return;
            }
            rt.rTypeRemark = txtRemark.Text;
            if (rtm.Insert(rt) > 0)
                MessageBox.Show("add successfully");
            LoadList("normal");
            panel1.Visible = false;
        }
        /// <summary>
        /// soft delete roomtype
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var roomtype = rtm.QuerySingle(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                if (roomtype != null)
                {
                    roomtype.rTypeIsDel = true;
                    rtm.Update(roomtype);
                    LoadList("normal");
                    MessageBox.Show("delete successfully");
                }
                else
                {
                    MessageBox.Show("errors happen");
                }
            }
            else
            {
                MessageBox.Show("choose one to delete");
            }
        }
        /// <summary>
        /// edit roomtype
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var roomtype = rtm.QuerySingle(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                if (roomtype != null)
                {
                    txtedittype.Text = roomtype.rTypeName;
                    txteditprice.Text = roomtype.rTypePrice.ToString();
                    txteditremark.Text = roomtype.rTypeRemark;
                }
                else
                {
                    MessageBox.Show("errors happen");
                }
            }
            else
            {
                MessageBox.Show("choose one to edit");
            }
        }
        /// <summary>
        /// close this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            var roomtype = rtm.QuerySingle(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            if (txtedittype.Text == "" && txteditprice.Text == "" && txteditremark.Text == "")
            {
                MessageBox.Show("dont leave anything empty");
                return;
            }
            if (roomtype != null)
            {
                roomtype.rTypeName = txtedittype.Text;
                try
                {
                    roomtype.rTypePrice = Convert.ToDecimal(txteditprice.Text);
                }
                catch
                {
                    MessageBox.Show("input right number");
                    return;
                }
                roomtype.rTypeRemark = txteditremark.Text;
                rtm.Update(roomtype);
                LoadList("normal");
                MessageBox.Show("Update successfully");
                panel2.Visible = false;
            }
            else
            {
                MessageBox.Show("errors happen");
            }


        }

        private void txteditcancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoadList("bin");
        }
    }
}
