using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MUN_ChairTools
{
    /// <summary>
    /// 会议初始化界面：会议信息的载入以及新会议的创建
    /// </summary>
    public partial class ConferenceLoadAndInit : Form
    {
        public static bool flag = false;

        ChooseConference chooseConference;

        private bool isLoadConference = false;

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

            this.CurrentConference = new Conference();
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
            else if(!isLoadConference)
            {
                //验证是否添加了国家
                if (!isAddCountry)
                {
                    MessageBox.Show("尚未添加国家！");
                    return;
                }
                else
                {
                    //创建Conference类  
                    this.CurrentConference = new Conference(this.textBoxConferenceName.Text, this.textBoxCommitteeName.Text, this.addCountryListForm.GetMainCountryList(), this.addCountryListForm.GetObserverCountryList());
                    
                    this.CurrentConference.ShowInfo();
                    //显示Session选项，是选中之前的session还是新建一个session
                    if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data"))
                    {
                        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data");
                    }

                    //再在这个目录下创建一个名为Conference名字的目录
                    if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName))
                    {
                        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName);
                    }

                    //然后创建一个CommitteeName的文件夹
                    if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName + "\\" + CurrentConference.CommitteeName))
                    {
                        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName + "\\" + CurrentConference.CommitteeName);
                    }

                    //创建一个TXT存放会议信息ConferenceInfo.txt
                    if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName + "\\" + CurrentConference.CommitteeName + "\\" + "ConferenceInfo.txt"))
                    {
                        File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName + "\\" + CurrentConference.CommitteeName + "\\" + "ConferenceInfo.txt").Close();
                    }

                    StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName + "\\" + CurrentConference.CommitteeName + "\\" + "ConferenceInfo.txt", false);
                    streamWriter.WriteLine(CurrentConference.ConferenceName);
                    streamWriter.WriteLine(CurrentConference.CommitteeName);
                    streamWriter.WriteLine(CurrentConference.CountryTotalNumber);
                    streamWriter.Close();

                    //创建一个TXT存放国家列表CountryList.txt
                    if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName + "\\" + CurrentConference.CommitteeName + "\\" + "CountryList.txt"))
                    {
                        File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName + "\\" + CurrentConference.CommitteeName + "\\" + "CountryList.txt").Close();
                    }

                    StreamWriter streamWriterCountryList = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName + "\\" + CurrentConference.CommitteeName + "\\" + "CountryList.txt", false);
                    //首先两行输入国家数（与会国+观察员）
                    streamWriterCountryList.WriteLine(CurrentConference.MainCountryNumber);
                    streamWriterCountryList.WriteLine(CurrentConference.ObserverCountryNumber);
                    for (int i = 0; i < CurrentConference.MainCountryList.Count; i++)
                    {
                        streamWriterCountryList.WriteLine(this.CurrentConference.MainCountryList[i].ChineseName);
                    }

                    for (int i = 0; i < CurrentConference.ObserverCountryList.Count; i++)
                    {
                        streamWriterCountryList.WriteLine(this.CurrentConference.ObserverCountryList[i].ChineseName);
                    }

                    streamWriterCountryList.Close();
                    //然后是在sessionChooser中每新建一个Session就新建一个session的txt

                    //创建一个新的议程
                    SessionChooser sessionChooser = new SessionChooser(this.CurrentConference);
                    sessionChooser.StartPosition = FormStartPosition.CenterScreen;
                    sessionChooser.Show();
                    this.Hide();
                }
                
                //此时已经新建了一个会议，则需要通过文件体现
                //如果没有则创建一个目录
               


               
            }
            else // 
            {
                SessionChooser sessionChooser = new SessionChooser(this.CurrentConference);
                sessionChooser.StartPosition = FormStartPosition.CenterScreen;
                sessionChooser.Show();
                this.WindowState = FormWindowState.Minimized;
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
            //this.buttonAddCountry.Enabled = !ConferenceLoadAndInit.isAddCountry;
        }

        //从文件中加载已有的数据
        private void buttonLoadFileData_Click(object sender, EventArgs e)
        {
            if (this.buttonLoadFileData.Text == "加载文件")
            {
                //查看我的文档中有无 MUN_DATA
                if(!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//MUN_Data"))
                {
                    MessageBox.Show("不存在MUN_Data文件夹！");
                    return;
                }

                DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//MUN_Data");
                DirectoryInfo[] conferenceDirectory = dir.GetDirectories();
                if(conferenceDirectory.Length > 0)
                {
                    //接着去形成一个候选框

                    chooseConference = new ChooseConference(this.CurrentConference, this);
                    chooseConference.StartPosition = FormStartPosition.CenterScreen;
                    chooseConference.Show();

                
                    //选择结束后 修改isLoadConference的值
                    this.isLoadConference = true;

                    
                    
                }
                else
                {
                    MessageBox.Show("没有！");
                
                }

                //修改按钮的Text值
                this.buttonLoadFileData.Text = "取消加载";
            }
            else //此时是按钮的选项是取消加载文件
            {
                this.isLoadConference = false;
                this.textBoxCommitteeName.Text = string.Empty;
                this.textBoxConferenceName.Text = string.Empty;
                this.numericUpDownCountryNumber.Value = 0;
                this.comboBoxOfficialLanguage.SelectedIndex = -1;

                this.buttonLoadFileData.Text = "加载文件";
            }
            
        }

        public void GetConference(Conference conference)
        {
            
            this.CurrentConference = conference;

            this.textBoxConferenceName.Text = CurrentConference.ConferenceName;
            this.textBoxCommitteeName.Text = CurrentConference.CommitteeName;
            this.numericUpDownCountryNumber.Value = CurrentConference.CountryTotalNumber;
            this.comboBoxOfficialLanguage.SelectedIndex = 1;
        }
    }
}
