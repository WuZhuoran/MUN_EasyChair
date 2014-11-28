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

            for (int i = 0; i < Conference.SessionNumber; i++ )
            {
                this.comboBoxSessionChooser.Items.Add("Session" + i + 1);
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
                MessageBox.Show("新建议程！");
                Conference.SessionNumber++;
                MessageBox.Show(Conference.SessionNumber.ToString());
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
