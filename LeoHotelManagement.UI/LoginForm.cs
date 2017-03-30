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
    
    public partial class LoginForm : Form
    {
        AdminManager am = new AdminManager();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" && password.Text == "")
            {
                MessageBox.Show("Input Your Username or Password");
                return;
            }
            var adminuser =  am.QuerySingle(new { uId = username.Text.Trim(),__o="and", uPwd = password.Text.Trim() });
            if (adminuser == null)
            {
                MessageBox.Show("username or password wrong");
                return;
            }
            else
            {
                MessageBox.Show("sign in successful");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
