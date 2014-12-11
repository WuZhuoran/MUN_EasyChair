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
        public int MinuteSetTime = 0;

        public int SecondSetTime = 0;

        public DateTime TimePass;

        bool isOpenSpeakersList = false;

        public Conference CurrentConference;

        /// <summary>
        /// 构造函数
        /// </summary>
        public MainForm(Conference conference)
        {
            InitializeComponent();
            this.timerSystemTime.Enabled = true;
            this.timerSystemTime.Start();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

            this.CurrentConference = conference;

            //显示会议信息
            this.richTextBoxRecord.Text += "会议名称:" + this.CurrentConference.ConferenceName + "\n会场名称：" + this.CurrentConference.CommitteeName + "\n议程：" + this.CurrentConference.TotalSessionList.Count;
            this.richTextBoxRecord.Text += "\n\n参会国家总数：" + this.CurrentConference.CountryTotalNumber + "\n到场国家：" + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].PresentMainCountryNumber + "+" + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].PresentObserverCountryNumber;
            this.richTextBoxRecord.Text += "简单多数为：" + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].SimpleMajority + "\n绝对多数为:" + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].TwoThirdsMajority;
        }

        /// <summary>
        /// 点击右上角关闭按钮时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("是否保存数据并退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Dispose();
                this.Close();
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
                
            }
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
        
        /// <summary>
        /// 计时器工作函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 计时器开始按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 倒计时暂停按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 设定时间的重置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 系统时间计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerSystemTime_Tick(object sender, EventArgs e)
        {
            this.labelSystemTime.Text = "系统时间：" + DateTime.Now.ToString();
        }

        /// <summary>
        /// 显示关于对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }

        public void WirteToRecord(string content)
        {
            this.richTextBoxRecord.Text += content;
            this.richTextBoxRecord.Text += "\n";
        }

        public void AddTimer(int seconds)
        {
            this.timerSetTime.Tick -= new EventHandler(timerSetTime_Tick);
            //获取数据并验证正确性

            this.MinuteSetTime = seconds / 60;
            this.SecondSetTime = seconds % 60;
            this.TimePass = DateTime.Parse("00:" + this.MinuteSetTime.ToString("00") + ":" + this.SecondSetTime.ToString("00"));
            this.labelSetTimeMinute.Text = this.MinuteSetTime.ToString("00") + ":" + this.SecondSetTime.ToString("00");


            //开始Timer
            this.timerSetTime.Enabled = true;
            this.timerSetTime.Tick += new EventHandler(timerSetTime_Tick);
            this.timerSetTime.Start();

            this.buttonSetTimeStart.Enabled = false;
            this.buttonSetTimeStart.ForeColor = Color.Gray;
        }

        private void UMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotionUMC motionUMC = new MotionUMC(this);
            motionUMC.StartPosition = FormStartPosition.CenterScreen;
            motionUMC.Show();
        }

        private void MCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotionMC motionMC = new MotionMC(this);
            motionMC.StartPosition = FormStartPosition.CenterScreen;
            motionMC.Show();
        }

        /// <summary>
        /// 开启住发言名单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSpeakersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    
    }


}
