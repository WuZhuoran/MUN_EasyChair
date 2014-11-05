using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MUN_ChairTools
{
    public partial class MainForm : Form
    {
        private int minutesTemp;

        private int secondsTemp;

        private bool pauseOrContinue = true; // false表示是暂停按钮， true表示继续按钮

        public MainForm()
        {
            InitializeComponent();
            this.timerSystemTime.Enabled = true;
            this.timerSystemTime.Start();
            this.timerSystemTime.Tick += new EventHandler(timerSystemTime_Tick);

            this.timerSetTime.Enabled = true;
            this.timerSetTime.Interval = 1000;
        }

        void timerSetTime_Tick(object sender, EventArgs e)
        {
            
            if (minutesTemp >= 0)
            {
                secondsTemp--;
                if (secondsTemp == 0)
                {
                    minutesTemp--;
                    this.labelSetTimeMinute.Text = minutesTemp.ToString();
                    secondsTemp = 59;
                }
                labelSetTimeSecond.Text = secondsTemp.ToString();
            }

            if (minutesTemp == 0 && secondsTemp <= 20)
            {
                this.labelSetTimeMinute.ForeColor = Color.Red;
                this.labelColon.ForeColor = Color.Red;
                this.labelSetTimeSecond.ForeColor = Color.Red;
            }

            if (minutesTemp == 0 && secondsTemp == 0)
            {
                this.timerSetTime.Stop();
            }
        }

        void timerSystemTime_Tick(object sender, EventArgs e)
        {
            this.labelSystemTime.Text = "系统时间： " + DateTime.Now.ToString();
        }

        private void panelMain_SizeChanged(object sender, EventArgs e)
        {
            this.groupBoxRecord.Size = new Size(this.panelMain.Size.Width - this.groupBoxTime.Size.Width, this.groupBoxInfo.Size.Height + this.groupBoxTime.Size.Height + 10);
            this.groupBoxInfo.Location = new Point(this.groupBoxRecord.Size.Width + 6, this.groupBoxTime.Size.Height + 3 + 10);
        }

        private void buttonSetTimeStart_Click(object sender, EventArgs e)
        {
            //开始计时
            int setTimeSecond = 0;
            this.secondsTemp = 0;
            this.minutesTemp = 0;
            this.labelSetTimeMinute.ForeColor = Color.Black;
            this.labelColon.ForeColor = Color.Black;
            this.labelSetTimeSecond.ForeColor = Color.Black;

            if (Int32.TryParse(this.numericUpDownSetTime.Value.ToString(), out setTimeSecond))
            {
                //首先把秒转换成 分：秒的形式
                //Console.WriteLine(this.numericUpDownSetTime.Value.ToString());
                if (setTimeSecond == 0)
                {
                    return;
                }

                minutesTemp = setTimeSecond / 60;
                secondsTemp = setTimeSecond - (minutesTemp * 60);

                this.labelSetTimeMinute.Text = minutesTemp.ToString();
                this.labelSetTimeSecond.Text = secondsTemp.ToString();

                this.timerSetTime.Enabled = true;
                this.timerSetTime.Start();

                this.timerSetTime.Tick+=new EventHandler(timerSetTime_Tick);

            }
            else
            {
                MessageBox.Show("请输入正确信息！");
            }
        }

        private void buttonSetTimePause_Click(object sender, EventArgs e)
        {
            //this.timerSetTime.Enabled = false;

            if (pauseOrContinue)
            {
                this.pauseOrContinue = !this.pauseOrContinue;
                this.buttonSetTimePause.Text = "继续";
                this.timerSetTime.Enabled = false;
            }
            else
            {
                this.pauseOrContinue = !this.pauseOrContinue;
                this.buttonSetTimePause.Text = "暂停";
                this.timerSetTime.Enabled = true;
            }
        }

        private void buttonSetTimeReset_Click(object sender, EventArgs e)
        {
            this.labelSetTimeSecond.Text = "00";
            this.labelSetTimeMinute.Text = "0";
            this.timerSetTime.Enabled = false;
            this.timerSetTime.Stop();
            
            this.numericUpDownSetTime.ResetText();

        }

    }
}
