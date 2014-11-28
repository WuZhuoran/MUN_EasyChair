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
    public partial class RollCallForm : Form
    {
        MainForm mainForm;

        public Conference CurrentConference;

        public CheckBox[] checkBoxCountry;

        public RollCallForm(Conference conference)
        {
            InitializeComponent();
            //初始化界面
            this.ControlBox = false;
            this.SizeChanged += new EventHandler(RollCallForm_SizeChanged);
            this.panelMainRollCall.Location = new Point(12, 12);
            this.AutoScroll = true;
            this.HorizontalScroll.Visible = true;
            this.CurrentConference = conference;

            //界面初始化结束
            int coloum = (int)Math.Sqrt((double)conference.CountryTotalNumber);
            int OffsetX = 0;
            int OffsetY = 0;
            int OffsetGap = 12;

            this.checkBoxCountry = new CheckBox[conference.CountryTotalNumber];

            for (int i = 0; i < conference.MainCountryList.Count; i++)
            {
                this.checkBoxCountry[i] = new CheckBox();
                this.checkBoxCountry[i].Text = conference.MainCountryList[i].ChineseName;
                this.checkBoxCountry[i].Location = new Point(OffsetX + OffsetGap, OffsetY + OffsetGap);
                this.checkBoxCountry[i].Font = new Font("微软雅黑", 12.25F, FontStyle.Regular);

                if ((i + 1) % coloum == 0)
                {
                    OffsetY = 0;
                    OffsetX += this.checkBoxCountry[i].Width;
                    //OffsetX += OffsetLabel;
                }
                else
                {
                    OffsetY += this.checkBoxCountry[i].Height;
                    OffsetY += OffsetGap;
                }
                this.panelMainRollCall.Controls.Add(this.checkBoxCountry[i]);
            }

            for (int i = conference.MainCountryList.Count; i < (conference.ObserverCountryList.Count + conference.MainCountryList.Count); i++)
            {
                this.checkBoxCountry[i] = new CheckBox();
                this.checkBoxCountry[i].Text = conference.ObserverCountryList[i - conference.MainCountryList.Count].ChineseName;
                this.checkBoxCountry[i].Location = new Point(OffsetX + OffsetGap, OffsetY + OffsetGap);
                this.checkBoxCountry[i].Font = new Font("微软雅黑", 12.25F, FontStyle.Regular);
                if ((i + 1) % coloum == 0)
                {
                    OffsetY = 0;
                    OffsetX += this.checkBoxCountry[i].Width;
                    //OffsetX += OffsetLabel;
                }
                else
                {
                    OffsetY += this.checkBoxCountry[i].Height;
                    OffsetY += OffsetGap;
                }
                this.checkBoxCountry[i].BackColor = Color.Green;
                this.panelMainRollCall.Controls.Add(this.checkBoxCountry[i]);
            }
            
        }

        void RollCallForm_SizeChanged(object sender, EventArgs e)
        {
            this.panelMainRollCall.Location = new Point(12, 12);
            this.panelMainRollCall.Width = this.Width - 12;
            this.panelMainRollCall.Height = this.Height - 100;

            this.buttonBack.Location = new Point(this.panelMainRollCall.Location.X, this.panelMainRollCall.Size.Height + this.panelMainRollCall.Location.Y + 10);
            this.buttonConfirm.Location = new Point(this.panelMainRollCall.Location.X + this.panelMainRollCall.Size.Width - this.buttonConfirm.Width - 10, this.buttonBack.Location.Y);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int MainCountryPresent = 0;
            int ObserverCountryPresent = 0;
            //修改Conference中的国家列表的中国家到场的值
            for (int i = 0; i < this.CurrentConference.MainCountryList.Count; i++)
            {
                if (this.checkBoxCountry[i].Checked)
                {
                    this.CurrentConference.MainCountryList[i].IsPresent = true;
                    MainCountryPresent++;
                }
                else
                {
                    this.CurrentConference.MainCountryList[i].IsPresent = false;
                }
            }

            for (int i = this.CurrentConference.MainCountryList.Count; i < this.CurrentConference.CountryTotalNumber; i++)
            {
                if (this.checkBoxCountry[i].Checked)//有问题？
                {
                    this.CurrentConference.ObserverCountryList[i - this.CurrentConference.MainCountryList.Count].IsPresent = true;
                    ObserverCountryPresent++;
                }
                else
                {
                    this.CurrentConference.ObserverCountryList[i - this.CurrentConference.MainCountryList.Count].IsPresent = true;
                }
            }

            
            //修改Conference中的各种多数的值
            this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].SimpleMajority = MainCountryPresent / 2 + 1;
            this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].TwoThirdsMajority = (int)(MainCountryPresent / 3 * 2);
            this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].PresentMainCountryNumber = MainCountryPresent;
            this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].PresentObserverCountryNumber = ObserverCountryPresent;
            //新建一个MainForm

            this.mainForm = new MainForm(this.CurrentConference);
            this.Close();
            mainForm.Show();
        }


    }
}
