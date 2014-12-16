using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MUN_ChairTools
{
    public partial class SessionChooser : Form
    {
        public Conference CurrentConference;

        public SessionChooser(Conference conference)
        {
            InitializeComponent();

            CurrentConference = conference;

            this.labelConferenceInfo.Text = "会议名称：" 
                                            + conference.ConferenceName + "\n会场名称：" 
                                            + conference.CommitteeName 
                                            + "\n国家数：" + (conference.MainCountryList.Count 
                                            + conference.ObserverCountryList.Count).ToString();

            //遍历文件中有多少session的文件
            //每一个session一个文件夹
            DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//MUN_Data//" + conference.ConferenceName + "//" + conference.CommitteeName);
            DirectoryInfo[] dirs = dir.GetDirectories();
            MessageBox.Show("子目录数目" + dirs.Length);

            Conference.SessionNumber = dirs.Length;

            for (int i = 1; i <= Conference.SessionNumber; i++ )
            {
                this.comboBoxSessionChooser.Items.Add("Session" + i);
                this.CurrentConference.TotalSessionList.Add(new Session(i));
                Conference.SessionNumber = dirs.Length; // 由于每次执行完上一句后Conference.SessionNumber都会清零 （原因是子类的实例初始化会影响父类的静态变量）
            }


            this.comboBoxSessionChooser.Items.Add("新建议程");

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //Session创建

            if(this.comboBoxSessionChooser.SelectedIndex == -1 || this.comboBoxSessionChooser.SelectedItem.ToString() == "未选择")
            {
                MessageBox.Show("未选择议程");
                return;
            }

            if(this.comboBoxSessionChooser.SelectedItem.ToString() == "新建议程")
            {
                Conference.SessionNumber++;
                //建立新议程的文件夹
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName + "\\" + CurrentConference.CommitteeName + "\\session" + Conference.SessionNumber))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MUN_Data\\" + CurrentConference.ConferenceName + "\\" + CurrentConference.CommitteeName + "\\session" + Conference.SessionNumber);
                }

                CurrentConference.TotalSessionList.Add(new Session(Conference.SessionNumber));
            }
            //窗口关闭
            this.Close();

            RollCallForm rollCallForm = new RollCallForm(CurrentConference);
            rollCallForm.StartPosition = FormStartPosition.CenterScreen;
            rollCallForm.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //关闭
            
            this.Close();
        }
    }
}
