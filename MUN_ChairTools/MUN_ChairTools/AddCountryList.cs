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
    public partial class AddCountryList : Form
    {
        Country a = new Country();

        public AddCountryList(int CountryNumbers)
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(AddCountryList_SizeChanged);
            this.buttonBack.Location = new Point(this.panelTotalCountry.Location.X, this.panelTotalCountry.Location.Y + this.panelTotalCountry.Size.Height + 10);
            this.buttonConfirm.Location = new Point(this.buttonBack.Location.X + this.panelTotalCountry.Size.Width - this.buttonConfirm.Width, this.buttonBack.Location.Y);
            
        }

        void AddCountryList_SizeChanged(object sender, EventArgs e)
        {
            this.panelTotalCountry.Location = new Point(12, 12);
            this.panelTotalCountry.Width = this.Width - 40;
            this.panelTotalCountry.Height = this.Height - 100;
            this.buttonBack.Location = new Point(this.panelTotalCountry.Location.X, this.panelTotalCountry.Location.Y + this.panelTotalCountry.Size.Height + 10);
            this.buttonConfirm.Location = new Point(this.buttonBack.Location.X + this.panelTotalCountry.Size.Width - this.buttonConfirm.Width, this.buttonBack.Location.Y);
        }

        //public List<Conference> GetCountryList()
        //{
            
        //}
    }
}
