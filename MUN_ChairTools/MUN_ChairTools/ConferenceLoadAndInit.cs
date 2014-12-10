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

                    StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName + "\\" + CurrentConference.CommitteeName + "\\" + "ConferenceInfo.txt", true);
                    streamWriter.WriteLine("会议名称" + CurrentConference.ConferenceName);
                    streamWriter.WriteLine("会场名称" + CurrentConference.CommitteeName);
                    streamWriter.WriteLine("国家数：" + CurrentConference.CountryTotalNumber);
                    streamWriter.Close();

                    //创建一个TXT存放国家列表CountryList.txt
                    if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName + "\\" + CurrentConference.CommitteeName + "\\" + "CountryList.txt"))
                    {
                        File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName + "\\" + CurrentConference.CommitteeName + "\\" + "CountryList.txt").Close();
                    }

                    StreamWriter streamWriterCountryList = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName + "\\" + CurrentConference.CommitteeName + "\\" + "CountryList.txt", true);
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
            DialogResult dr = MessageBox.Show("复议", "Second?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

    }
}
