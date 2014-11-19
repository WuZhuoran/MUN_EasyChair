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
        private int MinuteSetTime = 0;

        private int SecondSetTime = 0;

        private DateTime TimePass;

        public MainForm()
        {
            InitializeComponent();
            this.timerSystemTime.Enabled = true;
            this.timerSystemTime.Start();

            
            
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
            this.richTextBoxRecord.Width = this.groupBoxRecord.Width - 20;
            this.richTextBoxRecord.Height = this.groupBoxRecord.Height - 40;
        }

        void timerSetTime_Tick(object sender, EventArgs e)
        {
            if (this.TimePass != Convert.ToDateTime("00:00:00"))
            {
                this.TimePass = this.TimePass.AddSeconds(-1);
                this.labelSetTimeMinute.Text = this.TimePass.Minute.ToString("00") + ":" + this.TimePass.Second.ToString("00");

                if(this.TimePass.Minute == 0 && this.TimePass.Second <= 20)
                {
                    this.labelSetTimeMinute.ForeColor = Color.Red;
                }
            }
            else
            {
                this.timerSetTime.Stop();
            }
        }

        private void buttonSetTimeStart_Click(object sender, EventArgs e)
        {
            //自动关闭之前可能出现的Trik事件
            this.timerSetTime.Tick -= new EventHandler(timerSetTime_Tick);
            //获取数据并验证正确性
            int timeSetTime = 0;
            if(Int32.TryParse(this.numericUpDownSetTime.Value.ToString(), out timeSetTime))
            {
                this.MinuteSetTime = timeSetTime / 60;
                this.SecondSetTime = timeSetTime % 60;
                this.TimePass = DateTime.Parse("00:" + this.MinuteSetTime.ToString("00") + ":" + this.SecondSetTime.ToString("00"));
                this.labelSetTimeMinute.Text = this.MinuteSetTime.ToString("00") + ":" + this.SecondSetTime.ToString("00");

            }
            else
            {
                return;
            }
            
            //开始Timer
            this.timerSetTime.Enabled = true;
            this.timerSetTime.Tick += new EventHandler(timerSetTime_Tick);
            this.timerSetTime.Start();

            this.buttonSetTimeStart.Enabled = false;
            this.buttonSetTimeStart.ForeColor = Color.Gray;

        }

        private void buttonSetTimePause_Click(object sender, EventArgs e)
        {
            if(this.buttonSetTimePause.Text == "暂停")
            {
                this.buttonSetTimePause.Text = "继续";
                this.timerSetTime.Stop();
            }
            else if(this.buttonSetTimePause.Text == "继续")
            {
                this.buttonSetTimePause.Text = "暂停";
                this.timerSetTime.Start();
            }
            else
            {
                return;
            }
        }

        private void buttonSetTimeReset_Click(object sender, EventArgs e)
        {
            this.timerSetTime.Enabled = false;
            this.timerSetTime.Stop();
            this.timerSetTime.Interval = 1000;
            this.labelSetTimeMinute.Text = "";
            this.labelSetTimeMinute.ForeColor = Color.Black;
            this.timerSetTime.Tick -= new System.EventHandler(timerSetTime_Tick);
            
            this.SecondSetTime = 0;
            this.MinuteSetTime = 0;

            this.buttonSetTimeStart.Enabled = true;
            this.buttonSetTimeStart.ForeColor = Color.Black;
        }

        private void timerSystemTime_Tick(object sender, EventArgs e)
        {
            this.labelSystemTime.Text = "系统时间：" + DateTime.Now.ToString();
        }

        private void AboutBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }

    
        
    }


}
