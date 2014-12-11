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
    public partial class MotionMCMain : Form
    {
        public MainForm currentMainform;

        public ModeratedCaucus currentMC;

        private DateTime timePass;

        public MotionMCMain(MainForm mainfrom, ModeratedCaucus moderatedCaucus)
        {
            InitializeComponent();
            this.currentMainform = mainfrom;
            this.currentMC = moderatedCaucus;

            for (int i = 0; i < this.currentMainform.CurrentConference.MainCountryList.Count; i++ )
            {
                this.comboBoxAddCountry.Items.Add(this.currentMainform.CurrentConference.MainCountryList[i].ChineseName);
            }

            for (int i = 0; i < this.currentMainform.CurrentConference.ObserverCountryList.Count; i++ )
            {
                this.comboBoxAddCountry.Items.Add(this.currentMainform.CurrentConference.ObserverCountryList[i].ChineseName);
            }

            this.labelMCTopic.Text += currentMC.MotionTopic;
            this.labelTime.Text = "总时长为" + currentMC.TotalTime + "秒 每位代表" + currentMC.PerTime + "秒 共允许" + currentMC.TotalTime / currentMC.PerTime + "名代表发言";
        }

        /// <summary>
        /// 单击组件时 添加国家
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAddCountry_Click(object sender, EventArgs e)
        {
            //验证下拉菜单是否有选择
            if(this.comboBoxAddCountry.SelectedIndex == -1)
            {
                return;
            }

            //添加国家
            

            //TODO 做到可以控制添加的位置 初步想法：在每一个选中的项后面添加，如果没有选中的项就直接添加

            if (this.listBoxTest.SelectedIndex == -1)
            {
                this.listBoxTest.Items.Add(this.comboBoxAddCountry.SelectedItem);
            }
            else
            {
                //此时说明有选中的了，那就在选中的项后面加
                this.listBoxTest.Items.Insert(this.listBoxTest.SelectedIndex + 1, this.comboBoxAddCountry.SelectedItem);
            }
        }

        private void pictureBoxMinus_Click(object sender, EventArgs e)
        {
            if(this.listBoxTest.SelectedIndex == -1)
            {
                return;
            }

            this.listBoxTest.Items.Remove(this.listBoxTest.SelectedItem);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.timerPerTime.Tick -= new EventHandler(timerPerTime_Tick);

            int PerMinuteTime = this.currentMC.PerTime / 60;
            int PerSecondTime = this.currentMC.PerTime % 60;
            timePass = DateTime.Parse("00:" + PerMinuteTime.ToString("00") + ":" + PerSecondTime.ToString("00"));
            this.labelPerTime.Text = PerMinuteTime.ToString("00") + ":" + PerSecondTime.ToString("00");

            this.timerPerTime.Enabled = true;
            this.timerPerTime.Tick += new EventHandler(timerPerTime_Tick);
            this.timerPerTime.Start();
            

            this.progressBarPerTime.Maximum = this.currentMC.PerTime;
            this.progressBarPerTime.Value = 0;
            this.progressBarPerTime.Step = 1;
        }

        void timerPerTime_Tick(object sender, EventArgs e)
        {
            if (this.timePass != Convert.ToDateTime("00:00:00"))
            {
                this.timePass = this.timePass.AddSeconds(-1);
                this.progressBarPerTime.Value += this.progressBarPerTime.Step;
                this.labelPerTime.Text = this.timePass.Minute.ToString("00") + ":" + this.timePass.Second.ToString("00");

                if (this.timePass.Minute == 0 && this.timePass.Second <= 20)
                {
                    this.labelPerTime.ForeColor = Color.Red;
                }
            }
            else
            {
                this.timerPerTime.Stop();
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (this.buttonPause.Text == "暂停")
            {
                this.buttonPause.Text = "继续";
                this.timerPerTime.Stop();
            }
            else if (this.buttonPause.Text == "继续")
            {
                this.buttonPause.Text = "暂停";
                this.timerPerTime.Start();
            }
            else
            {
                return;
            }
        }

        private void buttonEndMotion_Click(object sender, EventArgs e)
        {
            //确认结束动议？
            
            //添加发言名单
            for (int i = 0; i < this.listBoxTest.Items.Count; i++)
            {
                this.currentMC.SpeechCountryList.Add(this.listBoxTest.Items[i].ToString());
            }
            //
            this.currentMC.MotionInfomationToRecord = "\n\n" + currentMC.MotionCountry + "动议有组织核心磋商 议题为：" + currentMC.MotionTopic + "\n总时长:" + currentMC.TotalTime + "秒 每位代表：" + currentMC.PerTime + "秒";
            this.currentMC.MotionInfomationToRecord += "发言名单为：";

            for (int i = 0; i < this.currentMC.SpeechCountryList.Count; i++ )
            {
                this.currentMC.MotionInfomationToRecord += this.currentMC.SpeechCountryList[i].ToString() + " ";
            }

            this.currentMainform.WirteToRecord(this.currentMC.MotionInfomationToRecord);

            this.Close();
        }
    }
}
