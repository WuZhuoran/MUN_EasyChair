using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MUN_ChairTools
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当窗体大小改变时触发的事件，自动调整控件位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelMain_SizeChanged(object sender, EventArgs e)
        {
            this.groupBoxRecord.Size = new Size(this.panelMain.Size.Width - this.groupBoxTime.Size.Width, this.groupBoxInfo.Size.Height + this.groupBoxTime.Size.Height + 10);
            this.groupBoxInfo.Location = new Point(this.groupBoxRecord.Size.Width + 6, this.groupBoxTime.Size.Height + 3 + 10);
        }

        private void buttonSetTimeStart_Click(object sender, EventArgs e)
        {
            this.Clock = 180;
            this.timerSetTime.Enabled = true;
            this.timerSetTime.Tick += new EventHandler(timerSetTime_Tick);
            this.timerSetTime.Start();
        }

        public int Clock = 180;

        void timerSetTime_Tick(object sender, EventArgs e)
        {
            Clock--;
            this.labelSetTimeMinute.Text = Clock.ToString();
            if (Clock == 0)
            {
                this.timerSetTime.Stop();
            }
        }

        private void buttonSetTimePause_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetTimeReset_Click(object sender, EventArgs e)
        {
            this.timerSetTime.Enabled = false;
            this.timerSetTime.Stop();
            this.timerSetTime.Interval = 1000;
            this.labelSetTimeMinute.Text = "";
        }

    }


}
