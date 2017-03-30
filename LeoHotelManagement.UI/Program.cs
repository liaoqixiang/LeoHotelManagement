using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeoHotelManagement.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //LoginForm login = new LoginForm();
            MainForm mf = new MainForm();
            Application.Run(mf);
            if (mf.DialogResult == DialogResult.OK)
                Application.Run(new Main_RoomType());
            if (mf.DialogResult == DialogResult.Yes)
                Application.Run(new Manage_Room());
            //if (login.DialogResult == DialogResult.OK)
            //{
            //    Application.Run(new Main_RoomType());
            //}


        }
    }
}
