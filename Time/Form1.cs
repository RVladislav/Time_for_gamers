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
    public partial class Form1 : Form
    {
        string h, m, s;

        public Form1()
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

    }
}
