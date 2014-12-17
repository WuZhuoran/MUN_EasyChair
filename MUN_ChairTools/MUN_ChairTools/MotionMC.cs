using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace MUN_ChairTools
{
    public partial class MotionMC : Form
    {
        public MainForm currentMainform;

        public MotionMC(MainForm mainform)
        {
            InitializeComponent();
            this.currentMainform = mainform;

            for (int i = 0; i < this.currentMainform.CurrentConference.MainCountryList.Count; i++)
            {
                this.comboBoxMotionCountry.Items.Add(this.currentMainform.CurrentConference.MainCountryList[i].ChineseName);
            }

            for (int i = 0; i < this.currentMainform.CurrentConference.ObserverCountryList.Count; i++)
            {
                this.comboBoxMotionCountry.Items.Add(this.currentMainform.CurrentConference.ObserverCountryList[i].ChineseName);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //验证各种不为空
            if(this.comboBoxMotionCountry.SelectedIndex == -1 || this.textBoxMotionTopic.Text == string.Empty || this.numericUpDownTotalTime.Value <= 0 || this.numericUpDownPerTime.Value <= 0)
            {
                MessageBox.Show("Error");
                return;
            }
            //验证时间输入的没问题
            if(this.numericUpDownPerTime.Value > this.numericUpDownTotalTime.Value)
            {
                MessageBox.Show("Error!");
                return;
            }
            //进入对话框界面
            //跳出复议框

            DialogResult dialogSecond = MessageBox.Show("请问场下又无任何复议？", "复议", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialogSecond == System.Windows.Forms.DialogResult.Yes)
            {
                //跳出投票框

                DialogResult dialogVoteMotion = MessageBox.Show("动议是否通过？", "动议投票", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogVoteMotion == System.Windows.Forms.DialogResult.Yes)
                {
                    //通过 进入MotionMCMain
                    MotionMCMain motionMCMain = new MotionMCMain(this.currentMainform, new ModeratedCaucus(this.comboBoxMotionCountry.SelectedItem.ToString(), this.textBoxMotionTopic.Text, (int)this.numericUpDownTotalTime.Value, (int)this.numericUpDownPerTime.Value));
                    motionMCMain.StartPosition = FormStartPosition.CenterScreen;
                    motionMCMain.Show();
                    
                    this.Close();
                    
                    
                    //进入有组织核心磋商的框
                }
                else if (dialogVoteMotion == System.Windows.Forms.DialogResult.No)
                {
                    this.currentMainform.WirteToRecord("\n\n" + this.comboBoxMotionCountry.SelectedItem.ToString() + "动议一个有组织核心磋商 \n总时长为：" + this.numericUpDownTotalTime.Value + "秒\n" + "\n议题为：" + this.textBoxMotionTopic.Text + "\n动议结果：失败！");
                    this.Close();
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
                this.currentMainform.WirteToRecord("\n\n" + this.comboBoxMotionCountry.SelectedItem.ToString() + "动议一个有组织核心磋商 \n总时长为：" + this.numericUpDownTotalTime.Value + "秒\n" + "\n议题为：" + this.textBoxMotionTopic.Text + "\n动议结果：失败！");
                this.Close();
            }
            else
            {
                return;
                //取消 不动
            }
            
        }
    }//end class
}//end namespace
