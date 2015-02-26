using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Time
{
    public partial class frmMain : Form
    {
        string h, m, s;
        int mX = 0;
        int mY = 0;

        //static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        //const UInt32 SWP_SHOWWINDOW = 0x0040;

        //internal struct RECT
        //{
        //    public int left;
        //    public int top;
        //    public int right;
        //    public int bottom;
        //}

        //[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        //internal static extern IntPtr GetForegroundWindow();

        //[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        //internal static extern bool GetWindowRect(IntPtr hWnd, ref RECT rect);

        //[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        //internal static extern void MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        //[DllImport("user32.dll", SetLastError = true)]
        //private static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

        //[DllImport("user32.dll")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);
        
        //[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        //static extern bool SetWindowPos(
        //     int hWnd,           // window handle
        //     int hWndInsertAfter,    // placement-order handle
        //     int X,          // horizontal position
        //     int Y,          // vertical position
        //     int cx,         // width
        //     int cy,         // height
        //     uint uFlags);

        public frmMain()
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
                h = "0" + h;

            if (m.Count() < 2)
                m = "0" + m;

            if (s.Count() < 2)
                s = "0" + s;

            lblTime.Text = h + ":" + m + ":" + s;

            //AssignTopmostWindow();
            //SetWindowPos(this.Handle.ToInt32(), -1, this.Left, this.Top, this.Width, this.Height, 0x0010 | 0x0200 | 0x0040);
            
        }

        //void AssignTopmostWindow()
        //{


        //    //IntPtr hWnd = FindWindow(null, "Time");

        //    //SetWindowPos(hWnd, HWND_TOPMOST, this.Location.X, this.Location.Y, this.Width, this.Height, SWP_SHOWWINDOW);

        //    IntPtr id;
        //    RECT Rect = new RECT();
        //    //Thread.Sleep(2000);
        //    id = GetForegroundWindow();
        //    GetWindowRect(id, ref Rect);
        //    if (id != this.Handle)
        //    {
        //        //MoveWindow(this.Handle, this.Location.X, this.Location.Y, this.Width, this.Height, true);
        //        SetWindowPos(this.Handle, HWND_TOPMOST, this.Location.X, this.Location.Y, this.Width, this.Height, SWP_SHOWWINDOW);
        //    }
      
        //}

        private void Main_Load(object sender, EventArgs e)
        {
            //прозрачное окно
            Color cl = lblTime.BackColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.White;
            this.TransparencyKey = System.Drawing.Color.Black;
            lblTime.BackColor = cl;

            Switch_Position(1);

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

        private void Switch_Position(byte locate)
        {
            Point pt = Screen.PrimaryScreen.WorkingArea.Location;

            switch (locate)
            {
                case 0:
                    pt.Offset(0, 0);
                    break;//left
                case 1:
                    pt.Offset(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, 0);
                    break;//Center
                case 2:
                    pt.Offset(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
                    break;//Right
            }
            this.Location = pt;
        }

        private void MoveWindow(MouseEventArgs e)
        {
            int tmp = e.X - mX;//направление сдвига окна
            byte locate = 0;
            if (10 < Math.Abs(tmp))
            {
                if (tmp > 0)
                {
                    if (this.Location.X == 0)
                        locate = 1;
                    else
                        locate = 2;

                    mY = 0;
                    mX = 0;
                }
                if (tmp < 0)
                {
                    if (this.Location.X == Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2)
                        locate = 0;
                    else
                        locate = 1;

                    mY = 0;
                    mX = 0;
                }

                Switch_Position(locate);
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
            Switch_Position(0);
        }

        private void tsmCenter_Click(object sender, EventArgs e)
        {
            Switch_Position(1);
        }

        private void tsmRight_Click(object sender, EventArgs e)
        {
            Switch_Position(2);
        }

    }
}
