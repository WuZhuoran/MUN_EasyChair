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
    /// <summary>
    /// 会议初始化界面：会议信息的载入以及新会议的创建
    /// </summary>
    public partial class ConferenceLoadAndInit : Form
    {
        public Conference CurrentConference;

        public static bool isAddCountry = false; //只有加载了国家时 才可以点确定

        AddCountryList addCountryListForm;



        /// <summary>
        /// 会议初始化 窗体
        /// </summary>
        public ConferenceLoadAndInit()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            
            
        }

        /// <summary>
        /// 退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Dispose();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //检查信息是否输入规范
            int countryNum = 0;

            if (this.textBoxCommitteeName.Text == string.Empty || 
                this.textBoxConferenceName.Text == string.Empty || 
                this.comboBoxOfficialLanguage.Text == string.Empty || 
                !Int32.TryParse(this.numericUpDownCountryNumber.Value.ToString(), out countryNum))
            {
                MessageBox.Show("请输入正确的信息！");
                return;
            }
            else
            {
                //验证是否添加了国家
                if (!isAddCountry)
                {
                    MessageBox.Show("尚未添加国家！");
                    return;
                }
                else
                {
                    MessageBox.Show("OK！");
                    //创建Conference类  
                    this.CurrentConference = new Conference(this.textBoxConferenceName.Text, this.textBoxCommitteeName.Text, this.addCountryListForm.GetMainCountryList(), this.addCountryListForm.GetObserverCountryList());
                    this.CurrentConference.ShowInfo();
                    //显示Session选项，是选中之前的session还是新建一个session

                    SessionChooser sessionChooser = new SessionChooser(this.CurrentConference);
                    sessionChooser.Show();
                }
               
            }
            
        }

        /// <summary>
        /// 添加国家
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCountry_Click(object sender, EventArgs e)
        {
            int countryNum = 0;

            if (this.textBoxCommitteeName.Text == string.Empty ||
                this.textBoxConferenceName.Text == string.Empty ||
                this.comboBoxOfficialLanguage.Text == string.Empty ||
                !Int32.TryParse(this.numericUpDownCountryNumber.Value.ToString(), out countryNum))
            {
                MessageBox.Show("请输入正确的信息！");
                return;
            }
            else
            {
                this.buttonAddCountry.Enabled = !ConferenceLoadAndInit.isAddCountry;
                this.addCountryListForm = new AddCountryList(countryNum);
                this.addCountryListForm.StartPosition = FormStartPosition.CenterScreen;
                this.addCountryListForm.Show();

                this.addCountryListForm.changeBottomStatus += new ChangeAddCountryBottomStatus(addCountryListForm_changeBottomStatus);
            }

            
        }

        void addCountryListForm_changeBottomStatus(bool status)
        {
            this.buttonAddCountry.Enabled = !ConferenceLoadAndInit.isAddCountry;
        }

    }
}
