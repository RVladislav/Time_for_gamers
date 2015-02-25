using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Diagnostics;
//using System.Runtime.InteropServices;

namespace Time
{
    public partial class Main : Form
    {
        string h, m, s;
        int mX = 0;
        int mY = 0;

        //public static extern IntPtr SetWindowPos(string hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
        //static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public Main()
        {
            TopMost = true; 
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





            //const short SWP_NOSIZE = 1;
            //const short SWP_NOZORDER = 0X4;
            //const int SWP_SHOWWINDOW = 0x0040;

            //Process[] processes = Process.GetProcesses();


            //foreach (var process in processes)
            //{
            //    IntPtr handle = FindWindow(null, lblTime.Text);
            //    string Text = handle.ToString();

            //    if (handle != IntPtr.Zero)
            //    {
            //        SetWindowPos(Text, 0, 0, 0, 0, 0, SWP_NOZORDER | SWP_NOSIZE | SWP_SHOWWINDOW);
            //    }
            //}




        }

        private void Main_Load(object sender, EventArgs e)
        {
            //прозрачное окно
            Color cl = lblTime.BackColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.White;
            this.TransparencyKey = System.Drawing.Color.Black;
            lblTime.BackColor = cl;

            this.Opacity = 0.8;
        }

        private void lblTime_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTime_MouseDown(object sender, MouseEventArgs e)
        {
            mX = e.X;
            mY = e.Y;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            mX = e.X;
            mY = e.Y;
        }

        private void MoveWindow(MouseEventArgs e)
        {
            int tmp = e.X - mX;//направление сдвига окна

            if (tmp > 0)
            {
                if (this.Location.X == 0)
                {
                    Point pt = Screen.PrimaryScreen.WorkingArea.Location;
                    pt.Offset(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, 0);
                    this.Location = pt;
                }
                else
                {
                    Point pt = Screen.PrimaryScreen.WorkingArea.Location;
                    pt.Offset(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
                    this.Location = pt;
                }

                mY = 0;
                mX = 0;
            }
            if (tmp < 0)
            {
                if (this.Location.X == Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2)
                {
                    Point pt = Screen.PrimaryScreen.WorkingArea.Location;
                    pt.Offset(0, 0);
                    this.Location = pt;
                }
                else
                {
                    Point pt = Screen.PrimaryScreen.WorkingArea.Location;
                    pt.Offset(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, 0);
                    this.Location = pt;
                }

                mY = 0;
                mX = 0;
            } 
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void lblTime_MouseUp(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void Switch_Text_Color(Color cl)
        {
            lblTime.ForeColor = cl;
        }

        private void Switch_Back_Color(Color cl)
        {
            this.BackColor = cl;
        }

        private void tsmC1_Click(object sender, EventArgs e)
        {
            Switch_Text_Color(Color.DarkRed);
        }

        private void tsmC2_Click(object sender, EventArgs e)
        {
            Switch_Text_Color(Color.Orange);
        }

        private void tsmC6_Click(object sender, EventArgs e)
        {
            Switch_Text_Color(Color.DeepPink);
        }

        private void tsmC3_Click(object sender, EventArgs e)
        {
            Switch_Text_Color(Color.LimeGreen);
        }

        private void tsmC4_Click(object sender, EventArgs e)
        {
            Switch_Text_Color(Color.DeepSkyBlue);
        }

        private void tsmC5_Click(object sender, EventArgs e)
        {
            Switch_Text_Color(Color.MediumOrchid);
        }

        private void tsmCB1_Click(object sender, EventArgs e)
        {
            Switch_Back_Color(Color.White);
        }

        private void tsmCB2_Click(object sender, EventArgs e)
        {
            Switch_Back_Color(Color.Black);
        }

        private void tsmLeft_Click(object sender, EventArgs e)
        {
            Point pt = Screen.PrimaryScreen.WorkingArea.Location;
            pt.Offset(0, 0);
            this.Location = pt;
        }

        private void tsmCenter_Click(object sender, EventArgs e)
        {
            Point pt = Screen.PrimaryScreen.WorkingArea.Location;
            pt.Offset(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, 0);
            this.Location = pt;
        }

        private void tsmRight_Click(object sender, EventArgs e)
        {
            Point pt = Screen.PrimaryScreen.WorkingArea.Location;
            pt.Offset(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
            this.Location = pt;
        }

    }
}
