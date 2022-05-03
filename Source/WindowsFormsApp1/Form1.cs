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
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Security;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]

        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int LEFTUP = 0x0004;
        private const int LEFTDOWN = 0x0002;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Open Minecraft...");
            Thread.Sleep(2500);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (buttonToggle.Text.Contains("on"))
            {
                clicktimer.Start();
                buttonToggle.Text = "Toogle : off";
            }
            else
            {
                clicktimer.Stop();
                buttonToggle.Text = "Toogle : on";
            }
        }

        private void guna2TrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            string max = MaxTrackBar.Value.ToString();
            labelMax.Text = "Max CPS: " + max;
        }

        private void MinTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            string min = MinTrackBar.Value.ToString();
            labelMin.Text = "Min CPS: " + min;
        }

        private void clicktimer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int maxcps = (int)Math.Round(1000.0 / (MaxTrackBar.Value + MinTrackBar.Value * 0.2));
            int mincps = (int)Math.Round(1000.0 / (MaxTrackBar.Value + MinTrackBar.Value * 0.4));
            try
            {
                clicktimer.Interval = rnd.Next(mincps, maxcps);
            }
            catch
            {
            }

            bool mousedown = MouseButtons == MouseButtons.Left;
            if (mousedown)
            {
                mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                Thread.Sleep(millisecondsTimeout: rnd.Next(1, 6));
                mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            }
        }

        private void labelMax_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxMC_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("ativado", "xxx", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
