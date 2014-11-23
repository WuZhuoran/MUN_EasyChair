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
        public CheckBox[] checkBoxCountry;

        public RollCallForm(Conference conference)
        {
            InitializeComponent();
            //初始化界面
            this.ControlBox = false;
            this.SizeChanged += new EventHandler(RollCallForm_SizeChanged);
            this.panelMainRollCall.Location = new Point(12, 12);
            
            //界面初始化结束
            int coloum = (int)Math.Sqrt((double)conference.CountryTotalNumber);
            int OffsetX = 0;
            int OffsetY = 0;
            int OffsetGap = 12;

            this.checkBoxCountry = new CheckBox[conference.CountryTotalNumber];

            for (int i = 0; i < conference.MainCountryList.Count; i++)
            {
                this.checkBoxCountry[i].Text = conference.MainCountryList[i].ChineseName;
                this.checkBoxCountry[i].Location = new Point(OffsetX + OffsetGap, OffsetY + OffsetGap);

                if ((i + 1) % conference.CountryTotalNumber == 0)
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
                this.checkBoxCountry[i - conference.MainCountryList.Count].Text = conference.ObserverCountryList[i - conference.MainCountryList.Count].ChineseName;
                if ((i + 1) % conference.CountryTotalNumber == 0)
                {
                    OffsetY = 0;
                    OffsetX += this.checkBoxCountry[i - conference.MainCountryList.Count].Width;
                    //OffsetX += OffsetLabel;
                }
                else
                {
                    OffsetY += this.checkBoxCountry[i - conference.MainCountryList.Count].Height;
                    OffsetY += OffsetGap;
                }
                this.checkBoxCountry[i - conference.MainCountryList.Count].BackColor = Color.Gray;
                this.panelMainRollCall.Controls.Add(this.checkBoxCountry[i - conference.MainCountryList.Count]);
            }
            
        }

        void RollCallForm_SizeChanged(object sender, EventArgs e)
        {
            this.panelMainRollCall.Location = new Point(12, 12);
            this.panelMainRollCall.Width = this.Width - 12;
            this.panelMainRollCall.Height = this.Height - 100;
        }


    }
}
