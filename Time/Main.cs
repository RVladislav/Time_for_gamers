using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class Main : Form
    {
        string h, m, s;

        public Main()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            h = DateTime.Now.Hour.ToString();
            m = DateTime.Now.Minute.ToString();
            s = DateTime.Now.Second.ToString();

            if (h.Count() < 2)
            {
                h = "0" + h;
            }
            if (m.Count() < 2)
            {
                m = "0" + m;
            }
            if (s.Count() < 2)
            {
                s = "0" + s;
            }

            lblTime.Text = h + ":" + m + ":" + s;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //прозрачное окно
            //Color cl = lblTime.BackColor;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.BackColor = System.Drawing.Color.WhiteSmoke;
            //this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            //lblTime.BackColor = cl;
            this.Opacity = 0.7;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point pt = Screen.PrimaryScreen.WorkingArea.Location;
            pt.Offset(0, 0);
            this.Location = pt;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point pt = Screen.PrimaryScreen.WorkingArea.Location;
            pt.Offset(Screen.PrimaryScreen.WorkingArea.Width/2 - this.Width/2, 0);
            this.Location = pt;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point pt = Screen.PrimaryScreen.WorkingArea.Location;
            pt.Offset(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
            this.Location = pt;
        }

        private void lblTime_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
