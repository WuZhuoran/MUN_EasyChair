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
    public partial class DocumentVote : Form
    {
        public Session currentSession;

        //public ListBox AllMainCountry;

        public ListView listViewAllMainCountry;

        public DocumentVote(Session session)
        {
            InitializeComponent();

            currentSession = session;

            this.listViewAllMainCountry = new ListView();
            this.listViewAllMainCountry.Location = new Point(0, 0);
            this.listViewAllMainCountry.Size = new Size(this.panelAllCountries.Size.Width, this.panelAllCountries.Size.Height);
            this.listViewAllMainCountry.Font = new Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listViewAllMainCountry.MultiSelect = false;
            this.listViewAllMainCountry.View = View.Details;
            
            this.listViewAllMainCountry.FullRowSelect = true;

            for (int i = 0; i < currentSession.MainCountryList.Count; i++ )
            {
                this.listViewAllMainCountry.Items.Add(this.currentSession.MainCountryList[i].ChineseName);
            }

            this.panelAllCountries.Controls.Add(this.listViewAllMainCountry);


            this.listViewAllMainCountry.LostFocus += new EventHandler(listViewAllMainCountry_LostFocus);
        }

        void listViewAllMainCountry_LostFocus(object sender, EventArgs e)
        {
            this.listViewAllMainCountry.SelectedItems.Clear();
        }

        /// <summary>
        /// 点击YET按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxVoteYes_Click(object sender, EventArgs e)
        {
            if (this.textBoxFileName.Text == string.Empty)
            {
                return;
            }

            if(this.listViewAllMainCountry.SelectedItems.Count <= 0)
            {
                return;
            }

            this.listViewAllMainCountry.SelectedItems[0].BackColor = Color.CornflowerBlue;
            
            

            

            

        }

        /// <summary>
        /// 点击NO按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxVoteNo_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 点击Absence按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxVoteAbsence_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 点击Pass按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxVotePass_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
