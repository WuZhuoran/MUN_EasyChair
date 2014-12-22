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

        public ListBox AllMainCountry;

        public DocumentVote(Session session)
        {
            InitializeComponent();

            currentSession = session;

            this.AllMainCountry = new ListBox();
            this.AllMainCountry.Location = new Point(this.panelAllCountries.Location.X, this.panelAllCountries.Location.Y);
            this.AllMainCountry.Size = this.panelAllCountries.Size;
            this.AllMainCountry.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            for (int i = 0; i < currentSession.MainCountryList.Count; i++ )
            {        
                this.AllMainCountry.Items.Add(currentSession.MainCountryList[i].ChineseName);
                
            }

            this.panelAllCountries.Controls.Add(this.AllMainCountry);
        }

        /// <summary>
        /// 点击YET按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxVoteYes_Click(object sender, EventArgs e)
        {

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
    }
}
