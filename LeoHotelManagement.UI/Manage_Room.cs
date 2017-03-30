using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeoHotelManagement.Model;
using LeoHotelManagement.BLL;
namespace LeoHotelManagement.UI
{
    public partial class Manage_Room : Form
    {
        public enum roomstatus
        {
            Vancancy,
            cleaning,
            Occuplied
        }

        RoomManager rm = new RoomManager();
        RoomTypeManager rtm = new RoomTypeManager();
        List<Room> list;
        List<string> roomtypename = new List<string>();
        public Manage_Room()
        {
            InitializeComponent();
        }

        private void toolstripadd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;


        }

        private void Manage_Room_Load(object sender, EventArgs e)
        {
            Loadlist();
        }

        private void Loadlist()
        {
            if (comboroomtype.DataSource == null)
            {
                var list1 = rtm.QueryList(0, 0, new { rTypeIsDel = false }, null).ToList();
                for (int i = 0; i < list1.Count; i++)
                {
                    roomtypename.Add(list1[i].rTypeName);
                }
                comboroomtype.DataSource = roomtypename;
                
            }
            comboroomtype.SelectedIndex = -1;
            list = rm.QueryList(0, 0, new { roomIsDel = true }, null).ToList();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = list;
            for (int i = 0; i < list.Count(); i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = rtm.QuerySingle(list[i].rTypeId).rTypeName;
                switch (list[i].roomStatus)
                {
                    case 0:
                        dataGridView1.Rows[i].Cells[2].Value = "Vancancy";
                        break;
                    case 1:
                        dataGridView1.Rows[i].Cells[2].Value = "cleaning";
                        break;
                    case 2:
                        dataGridView1.Rows[i].Cells[2].Value = "Occuplied";
                        break;
                }
                
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            
            try
            {
                Room r = new Room();
                r.roomId = Convert.ToInt32(txtroomnum.Text);
                r.roomFloor = Convert.ToInt32(combofloor.Text);
                r.rTypeId = rtm.QuerySingle(new { rTypeName = comboroomtype.SelectedValue.ToString() }).rTypeId;
                switch (comboroomstatus.Text.ToString())
                {
                    case "Vancancy":
                        r.roomStatus = (int)roomstatus.Vancancy;
                        break;
                    case "Occuplied":
                        r.roomStatus = (int)roomstatus.Occuplied;
                        break;
                    case "cleaning":
                        r.roomStatus = (int)roomstatus.cleaning;
                        break;
                }
                r.roomRemark = txtRemark.Text;
                r.roomIsDel = true;
                rm.Insert(r);
                MessageBox.Show("Insert Successfully");
                panel1.Visible = false;
                reset();
                Loadlist();
            }
            catch(Exception)
            {
                
                return;
            }


        }

        private void txtcancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            reset();

        }

        private void reset()
        {
            txtroomnum.Text = "";
            txtRemark.Text = "";
            comboroomtype.SelectedIndex = -1;
            combofloor.SelectedIndex = -1;
            comboroomstatus.SelectedIndex = -1;
        }
    }
}
