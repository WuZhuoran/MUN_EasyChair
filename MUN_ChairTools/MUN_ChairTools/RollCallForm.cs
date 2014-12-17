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
    public partial class RollCallForm : Form
    {
        MainForm mainForm;

        public bool isFirstTime = true;

        public Conference CurrentConference;

        public List<Country> PresentCountryListTemp { get; set; }

        public CheckBox[] checkBoxCountry;

        /// <summary>
        /// 构造函数 第一次生成窗体时使用
        /// </summary>
        /// <param name="conference">传入与写入信息的Conference类</param>
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
            this.PresentCountryListTemp = new List<Country>(this.CurrentConference.CountryTotalNumber);
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
                this.checkBoxCountry[i].BackColor = Color.DarkGray;
                this.panelMainRollCall.Controls.Add(this.checkBoxCountry[i]);
            }
            
        }

        /// <summary>
        /// 构造函数 第二次生成窗体时使用
        /// </summary>
        /// <param name="conference">传入与写入信息的Conference类</param>
        /// <param name="form">传入与写入信息的MainForm类</param>
        public RollCallForm(Conference conference, MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;

            //初始化界面
            this.ControlBox = false;
            this.SizeChanged += new EventHandler(RollCallForm_SizeChanged);
            this.panelMainRollCall.Location = new Point(12, 12);
            this.AutoScroll = true;
            this.HorizontalScroll.Visible = true;
            this.CurrentConference = conference;
            this.PresentCountryListTemp = new List<Country>(this.CurrentConference.CountryTotalNumber);
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
                this.checkBoxCountry[i].BackColor = Color.DarkGray;
                this.panelMainRollCall.Controls.Add(this.checkBoxCountry[i]);
            }    
        }

        /// <summary>
        /// 窗体大小改变时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RollCallForm_SizeChanged(object sender, EventArgs e)
        {
            this.panelMainRollCall.Location = new Point(12, 12);
            this.panelMainRollCall.Width = this.Width - 12;
            this.panelMainRollCall.Height = this.Height - 100;

            this.buttonBack.Location = new Point(this.panelMainRollCall.Location.X, this.panelMainRollCall.Size.Height + this.panelMainRollCall.Location.Y + 10);
            this.buttonConfirm.Location = new Point(this.panelMainRollCall.Location.X + this.panelMainRollCall.Size.Width - this.buttonConfirm.Width - 10, this.buttonBack.Location.Y);
        }

        /// <summary>
        /// 后退按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
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
            int MainCountryPresent = 0;
            int ObserverCountryPresent = 0;

            
            //修改Conference中的国家列表的中国家到场的值
            for (int i = 0; i < this.CurrentConference.MainCountryList.Count; i++)
            {
                if (this.checkBoxCountry[i].Checked)
                {
                    this.CurrentConference.MainCountryList[i].IsPresent = true;
                    this.PresentCountryListTemp.Add(this.CurrentConference.MainCountryList[i]);
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
                    this.PresentCountryListTemp.Add(this.CurrentConference.MainCountryList[i]);
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
            this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].CountryList = this.PresentCountryListTemp;
            this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].MainCountryList = this.CurrentConference.MainCountryList;
            this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].ObserverCountryList = this.CurrentConference.ObserverCountryList;
            this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].CommitteeName = this.CurrentConference.CommitteeName;
            this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].ConferenceName = this.CurrentConference.ConferenceName;
            //新建一个MainForm
            if (this.isFirstTime)
            {
                this.mainForm = new MainForm(this.CurrentConference);
                this.mainForm.Show();
                this.Close();
            }
            else
            {
                this.mainForm.Show();
                this.mainForm.ReloadInformationLabel("会场名称：\n" 
                    + this.CurrentConference.CommitteeName 
                    + "\n国家总数：" + this.CurrentConference.CountryTotalNumber + "\n到场国家数："
                    + (this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].PresentMainCountryNumber
                    + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].PresentObserverCountryNumber) + "\n简单多数："
                    + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].SimpleMajority + "\n绝对多数："
                    + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].TwoThirdsMajority);

                this.mainForm.WirteToRecord("\n参会国家总数：" + this.CurrentConference.CountryTotalNumber + "\n到场国家：" 
                    + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].PresentMainCountryNumber 
                    + "+" 
                    + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].PresentObserverCountryNumber
                    + "\n简单多数为：" 
                    + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].SimpleMajority 
                    + "\n绝对多数为:" 
                    + this.CurrentConference.TotalSessionList[this.CurrentConference.TotalSessionList.Count - 1].TwoThirdsMajority + "\n");
                
                this.Close();
                //不是第一次点击
            }
            
            
            
        }

        /// <summary>
        /// 检查之前已经道德国家
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCheakedPresent_Click(object sender, EventArgs e)
        {
            if (this.isFirstTime)
            {
                //第一次按就没用
                return;
            }
            else
            {
                //检查两个list
                for (int i = 0; i < this.CurrentConference.MainCountryList.Count; i++ )
                {
                    if (this.CurrentConference.MainCountryList[i].IsPresent)
                    {
                        this.checkBoxCountry[i].Checked = true;
                    }
                }

                for (int i = 0; i < this.CurrentConference.ObserverCountryList.Count; i++ )
                {
                    if(this.CurrentConference.ObserverCountryList[i].IsPresent)
                    {
                        this.checkBoxCountry[i + this.CurrentConference.MainCountryList.Count].Checked = true;
                    }
                }
            }
        }


    }
}
