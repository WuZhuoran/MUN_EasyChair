using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Resources;


namespace MUN_ChairTools
{
    public delegate void ChangeAddCountryBottomStatus(bool status);

    public partial class AddCountryList : Form
    {

        int ObserverNumber = 0;

        TextBox[] CountryNameInput;

        Label[] CountrySerialNum;

        List<Country> MainCountryList;

        List<Country> ObserverCountryList;

        public event ChangeAddCountryBottomStatus changeBottomStatus; //委托实例 用来改变ConferenceLoadAndInit的状态

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="CountryNumbers"></param>
        public AddCountryList(int CountryNumbers)
        {
            InitializeComponent();

            this.MainCountryList = new List<Country>(CountryNumbers);

            this.SizeChanged += new EventHandler(AddCountryList_SizeChanged);
            this.buttonBack.Location = new Point(this.panelTotalCountry.Location.X, this.panelTotalCountry.Location.Y + this.panelTotalCountry.Size.Height + 10);
            this.buttonConfirm.Location = new Point(this.buttonBack.Location.X + this.panelTotalCountry.Size.Width - this.buttonConfirm.Width, this.buttonBack.Location.Y);
            this.AutoScroll = true;
            this.HorizontalScroll.Visible = true;
            

            //添加国家列表 每列10个 总共 CountryNumbers / 10 列

            this.CountryNameInput = new TextBox[CountryNumbers];
            this.CountrySerialNum = new Label[CountryNumbers];

            int OffsetX = 0;
            int OffsetY = 0;
            int NumbersPerColumn = (int)Math.Sqrt((double)CountryNumbers); //每一列的国家数
            int OffsetLabel = 35;

            for (int i = 0; i < CountryNumbers; i++ )
            {
                this.CountryNameInput[i] = new TextBox();
                this.CountrySerialNum[i] = new Label();

                this.CountryNameInput[i].Size = new Size(100,15);
                this.CountryNameInput[i].Font = new Font("微软雅黑", 12.25F, FontStyle.Regular);
                this.CountryNameInput[i].BackColor = Color.White;
                this.CountryNameInput[i].Location = new Point(OffsetLabel + OffsetX, OffsetLabel + OffsetY);

                if ((i + 1) % NumbersPerColumn == 0)
                {
                    //要换列了
                    OffsetY = 0;
                    OffsetX += this.CountryNameInput[i].Width;
                    OffsetX += OffsetLabel;
                }
                else
                {
                    OffsetY += this.CountryNameInput[i].Height;
                    OffsetY += OffsetLabel;
                }

                this.panelTotalCountry.Controls.Add(this.CountryNameInput[i]);

                this.CountrySerialNum[i].Font = new Font("微软雅黑", 12.25F, FontStyle.Regular);
                this.CountrySerialNum[i].Text = (i + 1).ToString();
                this.CountrySerialNum[i].Location = new Point(this.CountryNameInput[i].Location.X - OffsetLabel, this.CountryNameInput[i].Location.Y);
                this.CountrySerialNum[i].TextAlign = ContentAlignment.MiddleLeft;
                

                //给Label一个单击的事件
                this.CountrySerialNum[i].Click+=new EventHandler(AddCountryList_Click);

                this.panelTotalCountry.Controls.Add(this.CountrySerialNum[i]);
                
            }

            if(CountryNumbers >= 15)
            {
                this.Size = new Size(this.CountryNameInput[0].Width * (CountryNumbers / NumbersPerColumn) + OffsetLabel * (CountryNumbers / NumbersPerColumn) + 40,
                                    this.CountryNameInput[0].Height * NumbersPerColumn + OffsetLabel * NumbersPerColumn + 200);
            }
            else
            {
                this.Size = new Size(450, 350);
                this.panelTotalCountry.Location = new Point(12, 12);
                this.panelTotalCountry.Width = this.Width - 40;
                this.panelTotalCountry.Height = this.Height - 100;
            }
            
            
        }

        /// <summary>
        /// 单击TextBox之前对应的控件时，可以修改国家性质（与会国或者观察员等）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddCountryList_Click(object sender, EventArgs e)
        {
            if (this.CountryNameInput[Int32.Parse(((Label)sender).Text) - 1].BackColor == Color.White)
            {
                this.CountryNameInput[Int32.Parse(((Label)sender).Text) - 1].BackColor = Color.DarkGray;
                this.ObserverNumber++;
            }
            else
            {
                this.CountryNameInput[Int32.Parse(((Label)sender).Text) - 1].BackColor = Color.White;
                this.ObserverNumber--;
            }
            

            
        }

        /// <summary>
        /// 窗体大小改变时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddCountryList_SizeChanged(object sender, EventArgs e)
        {
            this.panelTotalCountry.Location = new Point(12, 12);
            this.panelTotalCountry.Width = this.Width - 40;
            this.panelTotalCountry.Height = this.Height - 100;
            this.buttonBack.Location = new Point(this.panelTotalCountry.Location.X, this.panelTotalCountry.Location.Y + this.panelTotalCountry.Size.Height + 10);
            this.buttonConfirm.Location = new Point(this.buttonBack.Location.X + this.panelTotalCountry.Size.Width - this.buttonConfirm.Width, this.buttonBack.Location.Y);
        }

        /// <summary>
        /// 确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //首先检查输入完整性
            Regex regexOnlyNumbers = new Regex(@"[^0-9]");
            this.MainCountryList.Clear();
            this.ObserverCountryList = new List<Country>(ObserverNumber);

            for (int i = 0; i < this.MainCountryList.Capacity; i++)
            {
                
                if (this.CountryNameInput[i].Text == string.Empty || !regexOnlyNumbers.IsMatch(this.CountryNameInput[i].Text))
                {
                    MessageBox.Show("有国家未输入完全！");
                    return;
                }

                if(this.CountryNameInput[i].BackColor == Color.White)
                {
                    //国家
                    this.MainCountryList.Add(new Country(this.CountryNameInput[i].Text, CountryType.COUNTRY));
                }
                else
                {
                    //观察员
                    this.ObserverCountryList.Add(new Country(this.CountryNameInput[i].Text, CountryType.OBVERSEVER));
                }
            }
            MessageBox.Show("共输入" + (this.MainCountryList.Count + this.ObserverCountryList.Count) + "个国家。");

            ConferenceLoadAndInit.isAddCountry = true;
            this.Visible = false;
        }

        public List<Country> GetMainCountryList()
        {
            return this.MainCountryList;
        }

        public List<Country> GetObserverCountryList()
        {
            return this.ObserverCountryList;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ConferenceLoadAndInit.isAddCountry = false;
            this.changeBottomStatus(ConferenceLoadAndInit.isAddCountry);
        }
    }
}
