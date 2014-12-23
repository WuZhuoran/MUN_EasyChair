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
            this.listViewAllMainCountry.View = View.List;
            this.listViewAllMainCountry.MultiSelect = false;
            

            for (int i = 0; i < currentSession.MainCountryList.Count; i++ )
            {
                this.listViewAllMainCountry.Items.Add(this.currentSession.MainCountryList[i].ChineseName);
            }

            this.panelAllCountries.Controls.Add(this.listViewAllMainCountry);
            //this.AllMainCountry = new ListBox();
            ////this.AllMainCountry.Margin = new Padding(0, 0, 0, 0);
            //this.AllMainCountry.Location = new Point(0, 0);
            //this.AllMainCountry.Size = new Size(this.panelAllCountries.Size.Width, this.panelAllCountries.Size.Height);
            //this.AllMainCountry.Anchor = AnchorStyles.Top;
            //this.AllMainCountry.Anchor = AnchorStyles.Left;
            //this.AllMainCountry.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //this.AllMainCountry.MultiColumn = true;
            //this.AllMainCountry.ColumnWidth = this.panelAllCountries.Size.Width / 2;
            //for (int i = 0; i < currentSession.MainCountryList.Count; i++ )
            //{        
            //    this.AllMainCountry.Items.Add(currentSession.MainCountryList[i].ChineseName);
                
            //}
            //this.AllMainCountry.DrawMode = DrawMode.OwnerDrawFixed;
            //this.panelAllCountries.Controls.Add(this.AllMainCountry);
            
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

            //if (this.AllMainCountry.SelectedIndex == -1)
            //{
            //    return;
            //}

            //this.AllMainCountry.SelectedIndex++;

            

        }

        /// <summary>
        /// 点击NO按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxVoteNo_Click(object sender, EventArgs e)
        {
            //if (this.textBoxFileName.Text == string.Empty)
            //{
            //    return;
            //}

            //if (this.AllMainCountry.SelectedIndex == -1)
            //{
            //    return;
            //}
            //this.AllMainCountry.Controls[this.AllMainCountry.SelectedIndex].ForeColor = Color.Red;
            //this.AllMainCountry.SelectedIndex++;
        }

        /// <summary>
        /// 点击Absence按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxVoteAbsence_Click(object sender, EventArgs e)
        {
            //if (this.textBoxFileName.Text == string.Empty)
            //{
            //    return;
            //}

            //if (this.AllMainCountry.SelectedIndex == -1)
            //{
            //    return;
            //}
            //this.AllMainCountry.Controls[this.AllMainCountry.SelectedIndex].ForeColor = Color.Purple;
            //this.AllMainCountry.SelectedIndex++;
        }

        /// <summary>
        /// 点击Pass按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxVotePass_Click(object sender, EventArgs e)
        {
            //if (this.textBoxFileName.Text == string.Empty)
            //{
            //    return;
            //}

            //if (this.AllMainCountry.SelectedIndex == -1)
            //{
            //    return;
            //}
            //this.AllMainCountry.Controls[this.AllMainCountry.SelectedIndex].ForeColor = Color.White;
            //this.AllMainCountry.SelectedIndex++;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
