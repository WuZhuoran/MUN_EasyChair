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
    public partial class MotionUMC : Form
    {
        private MainForm currentMainform;

        public MotionUMC(MainForm mainForm)
        {
            InitializeComponent();
            this.currentMainform = mainForm;
            for (int i = 0; i < this.currentMainform.CurrentConference.MainCountryList.Count; i++)
            {
                this.comboBoxMotionCountry.Items.Add(this.currentMainform.CurrentConference.MainCountryList[i].ChineseName);
            }
            for (int i = 0; i < this.currentMainform.CurrentConference.ObserverCountryList.Count; i++)
            {
                this.comboBoxMotionCountry.Items.Add(this.currentMainform.CurrentConference.ObserverCountryList[i].ChineseName);  
            }
            
        }



        /// <summary>
        /// 取消框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int UMCtime = 0;
            //检查输入
            if(this.comboBoxMotionCountry.SelectedIndex != -1 && !Int32.TryParse(this.numericUpDownUMCTime.Value.ToString(), out UMCtime))
            {
                MessageBox.Show("Error!");
                return;
            }
            //跳出复议框
            DialogResult dialogSecond = MessageBox.Show("请问场下又无任何复议？", "复议", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(dialogSecond == System.Windows.Forms.DialogResult.Yes)
            {
                //跳出投票框

                DialogResult dialogVoteMotion = MessageBox.Show("动议是否通过？", "动议投票", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(dialogVoteMotion == System.Windows.Forms.DialogResult.Yes)
                {
                    //通过 开始计时
                    this.currentMainform.AddTimer(Convert.ToInt32(this.numericUpDownUMCTime.Value));
                    this.currentMainform.WirteToRecord("\n" + this.comboBoxMotionCountry.SelectedItem.ToString() + "动议一个无组织核心磋商 \n总时长为：" + this.numericUpDownUMCTime.Value + "秒\n" + "动议结果：成功！");
                    this.Close();
                    //TODO 第二种思路，把这个和主计时器分开
                }
                else if(dialogVoteMotion == System.Windows.Forms.DialogResult.No)
                {
                    this.currentMainform.WirteToRecord("\n" + this.comboBoxMotionCountry.SelectedItem.ToString() + "动议一个无组织核心磋商 \n总时长为：" + this.numericUpDownUMCTime.Value + "秒\n" + "动议结果：失败！");
                    this.Close();
                }
                else
                {
                    //取消 那么久这个窗口关闭
                    return;
                }
            }
            else if(dialogSecond == System.Windows.Forms.DialogResult.No)
            {
                //直接失败 输出
                this.currentMainform.WirteToRecord("\n" + this.comboBoxMotionCountry.SelectedItem.ToString() + "动议一个无组织核心磋商 \n总时长为：" + this.numericUpDownUMCTime.Value + "秒\n" + "动议结果：失败！");
                this.Close();
            }
            else
            {
                return;
                //取消 不动
            }
            //跳出判断框
        }
    }
}
