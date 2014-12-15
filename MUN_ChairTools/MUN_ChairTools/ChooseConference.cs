using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MUN_ChairTools
{
    public delegate void DeliverConferenceHeader(Conference conference);

    public partial class ChooseConference : Form
    {
        public Conference CurrentConference;

        

        public event DeliverConferenceHeader deliverConference;

        public ChooseConference(Conference conference)
        {
            InitializeComponent();

            this.CurrentConference = conference;

            DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//MUN_Data");
            DirectoryInfo[] conferenceDirectory = dir.GetDirectories();

            for (int i = 0; i < conferenceDirectory.Length; i++ )
            {
                this.listBoxConference.Items.Add(conferenceDirectory[i].Name);
            }

            this.listBoxConference.SelectedIndexChanged += new EventHandler(listBoxConference_SelectedIndexChanged);

            this.FormClosing += new FormClosingEventHandler(ChooseConference_FormClosing);
        }

        /// <summary>
        /// 关闭本窗体时发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ChooseConference_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.deliverConference(this.CurrentConference);
            
        }

        /// <summary>
        /// 当选择不同index的时候触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void listBoxConference_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBoxConference.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                DirectoryInfo dirs = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//MUN_Data" + "//" + this.listBoxConference.SelectedItem.ToString());
                DirectoryInfo[] committeeDirectory = dirs.GetDirectories();
                if(committeeDirectory.Length > 0)
                {
                    this.listBoxCommittee.Items.Clear();
                    for (int i = 0; i < committeeDirectory.Length; i++ )
                    {
                        this.listBoxCommittee.Items.Add(committeeDirectory[i].Name);
                    }
                }
                else
                {
                    MessageBox.Show("该会议中没有相应会场 请新建");
                }
            }
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //需要同时选中 两个listbox框
            if (this.listBoxConference.SelectedIndex == -1 || this.listBoxCommittee.SelectedIndex == -1)
            {
                MessageBox.Show("请选择对于会议与会场！");
                return;
            }
            else
            {
                try
                {
                    StreamReader streamReader1 = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//MUN_Data//" + listBoxConference.SelectedItem.ToString() + "//" + listBoxCommittee.SelectedItem.ToString() + "//ConferenceInfo.txt");
                    StreamReader streamReader2 = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//MUN_Data//" + listBoxConference.SelectedItem.ToString() + "//" + listBoxCommittee.SelectedItem.ToString() + "//CountryList.txt");
                    Console.WriteLine(streamReader1.BaseStream.Length + "\\\\\\" + streamReader2.ToString());

                    this.CurrentConference.ConferenceName = streamReader1.ReadLine();
                    this.CurrentConference.CommitteeName = streamReader1.ReadLine();
                    this.CurrentConference.CountryTotalNumber = Int32.Parse(streamReader1.ReadLine());

                    this.CurrentConference.MainCountryNumber = Int32.Parse(streamReader2.ReadLine());
                    this.CurrentConference.ObserverCountryNumber = Int32.Parse(streamReader2.ReadLine());
                    for (int i = 0; i < this.CurrentConference.MainCountryNumber; i++)
                    {
                        this.CurrentConference.MainCountryList.Add(new Country(streamReader2.ReadLine(), CountryType.COUNTRY));
                    }
                    for (int i = 0; i < this.CurrentConference.ObserverCountryNumber; i++ )
                    {
                        this.CurrentConference.ObserverCountryList.Add(new Country(streamReader2.ReadLine(), CountryType.OBVERSEVER));
                    }
                    streamReader1.Close();
                    streamReader1.Close();
                    //文件读取完毕

                    ConferenceLoadAndInit.flag = true;

                    this.Close();
                }
                catch (IOException exception)
                {
                    MessageBox.Show(exception.Message);
                }
                
            }
        }

        public Conference GetConferenceInfo()
        {
            return this.CurrentConference;
        }
    }
}
