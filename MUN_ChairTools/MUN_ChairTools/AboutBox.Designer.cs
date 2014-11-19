namespace MUN_ChairTools
{
    partial class AboutBox
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxUNFlag = new System.Windows.Forms.PictureBox();
            this.panelAuthorization = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUNFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUNFlag
            // 
            this.pictureBoxUNFlag.Image = global::MUN_ChairTools.Properties.Resources.UnitedNationFlag;
            this.pictureBoxUNFlag.Location = new System.Drawing.Point(-1, 78);
            this.pictureBoxUNFlag.Name = "pictureBoxUNFlag";
            this.pictureBoxUNFlag.Size = new System.Drawing.Size(330, 220);
            this.pictureBoxUNFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUNFlag.TabIndex = 0;
            this.pictureBoxUNFlag.TabStop = false;
            // 
            // panelAuthorization
            // 
            this.panelAuthorization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAuthorization.Location = new System.Drawing.Point(-1, 0);
            this.panelAuthorization.Name = "panelAuthorization";
            this.panelAuthorization.Size = new System.Drawing.Size(774, 77);
            this.panelAuthorization.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(683, 264);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 297);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panelAuthorization);
            this.Controls.Add(this.pictureBoxUNFlag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于 MUN Chair Tools";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUNFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUNFlag;
        private System.Windows.Forms.Panel panelAuthorization;
        private System.Windows.Forms.Button buttonOK;

    }
}
