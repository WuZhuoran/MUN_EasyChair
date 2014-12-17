using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
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
        /// <param name="conference">传入主窗口的Conferen类实例</param>
        public MainForm(Conference conference)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.timerSystemTime.Enabled = true;
            this.timerSystemTime.Start();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

            this.CurrentConference = conference;

            //显示会议信息
            this.richTextBoxRecord.Text += "会议名称:" + this.CurrentConference.ConferenceName + "\n会场名称：" + this.CurrentConference.CommitteeName + "\n议程：" + this.CurrentConference.TotalSessionList.Count;
            this.richTextBoxRecord.Text += "\n\n参会国家总数：" + this.CurrentConference.CountryTotalNumber + "\n到场国家：" + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].PresentMainCountryNumber + "+" + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].PresentObserverCountryNumber;
            this.richTextBoxRecord.Text += "\n简单多数为：" + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].SimpleMajority + "\n绝对多数为:" + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].TwoThirdsMajority;

            this.listBoxSpeakersList.Visible = false;
            this.comboBoxChooseCountry.Visible = false;
            this.pictureBoxCountryMinus.Visible = false;
            this.pictureBoxCountryPlus.Visible = false;

            if(this.isOpenSpeakersList)
            {
                //此时说明不是第一次开启窗体 住发言名单已经开启
            }

            this.labelConferenceInformation.Text = "会场名称：\n" + this.CurrentConference.CommitteeName + "\n国家总数：" + this.CurrentConference.CountryTotalNumber + "\n到场国家数：" + (this.CurrentConference.TotalSessionList[Conference.SessionNumber].PresentMainCountryNumber + this.CurrentConference.TotalSessionList[Conference.SessionNumber].PresentObserverCountryNumber) + "\n简单多数：" + this.CurrentConference.TotalSessionList[Conference.SessionNumber].SimpleMajority + "\n绝对多数：" + this.CurrentConference.TotalSessionList[Conference.SessionNumber].TwoThirdsMajority;
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
                //进行信息保存工作
                //1. 保存议程基本信息

                //2. 保存主发言名单
                for (int i = 0; i < this.listBoxSpeakersList.Items.Count; i++ )
                {
                    this.CurrentConference.SpeakersList.Add(this.listBoxSpeakersList.Items[i].ToString());
                }
                //3. 保存会议记录信息

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

        /// <summary>
        /// 无组织核心磋商
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotionUMC motionUMC = new MotionUMC(this);
            motionUMC.StartPosition = FormStartPosition.CenterScreen;
            motionUMC.Show();
        }

        /// <summary>
        /// 有主持核心磋商
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (this.isOpenSpeakersList)
            { 
                //此时已经开了住发言名单 那么就
                MessageBox.Show("主发言名单已经开启！");
                return;
            }

            //跳出复议框
            DialogResult dialogSecond = MessageBox.Show("请问场下又无任何复议？", "复议", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogSecond == System.Windows.Forms.DialogResult.Yes)
            {
                //跳出投票框

                DialogResult dialogVoteMotion = MessageBox.Show("动议是否通过？", "动议投票", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogVoteMotion == System.Windows.Forms.DialogResult.Yes)
                {
                    //通过 开始计时
                    this.listBoxSpeakersList.Visible = true;
                    this.comboBoxChooseCountry.Visible = true;
                    this.pictureBoxCountryMinus.Visible = true;
                    this.pictureBoxCountryPlus.Visible = true;

                    for (int i = 0; i < this.CurrentConference.TotalSessionList[Conference.SessionNumber].CountryList.Count; i++ )
                    {
                        this.comboBoxChooseCountry.Items.Add(this.CurrentConference.TotalSessionList[Conference.SessionNumber].CountryList[i].ChineseName);
                    }
                    
                    //TODO 第二种思路，把这个和主计时器分开
                }
                else if (dialogVoteMotion == System.Windows.Forms.DialogResult.No)
                {
   
                    
                }
                else
                {
                    //取消 那么久这个窗口关闭
                    return;
                }
            }
            else if (dialogSecond == System.Windows.Forms.DialogResult.No)
            {
                //直接失败 输出
              
                
            }
            else
            {
                return;
                //取消 不动
            }


            
        }

        /// <summary>
        /// 主发言名单中 添加国家
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxCountryPlus_Click(object sender, EventArgs e)
        {
            if(this.comboBoxChooseCountry.SelectedIndex == -1)
            {
                return;
            }

            if (this.listBoxSpeakersList.SelectedIndex == -1)
            {
                this.listBoxSpeakersList.Items.Add(this.comboBoxChooseCountry.SelectedItem);
            }
            else
            {
                this.listBoxSpeakersList.Items.Insert(this.listBoxSpeakersList.SelectedIndex + 1, this.comboBoxChooseCountry.SelectedItem);
            }



        }

        /// <summary>
        /// 点名系统 做到可以随时点名随时更新数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RollCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RollCallForm rollCallForm = new RollCallForm(this.CurrentConference, this);
            rollCallForm.isFirstTime = false;
            rollCallForm.StartPosition = FormStartPosition.CenterParent;
            rollCallForm.Show();
        }

        /// <summary>
        /// 主发言名单 减少国家
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxCountryMinus_Click(object sender, EventArgs e)
        {
            if (this.listBoxSpeakersList.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                this.listBoxSpeakersList.Items.RemoveAt(this.listBoxSpeakersList.SelectedIndex);
            }
        }

        /// <summary>
        /// 更新主发言名单旁边的信息
        /// </summary>
        /// <param name="labelContent">写到信息栏中窗口的内容</param>
        public void ReloadInformationLabel(string labelContent)
        {
            this.labelConferenceInformation.Text = labelContent;
        }

        /// <summary>
        /// 向Record主窗口 写入一个string
        /// </summary>
        /// <param name="content">写到主窗口中的内容</param>
        public void WirteToRecord(string content)
        {
            this.richTextBoxRecord.Text += content;
            this.richTextBoxRecord.Text += "\n\n";
        }

        /// <summary>
        /// 给主窗口的Timer空间一个计时
        /// </summary>
        /// <param name="seconds">时间控件的秒数</param>
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
    }


}
