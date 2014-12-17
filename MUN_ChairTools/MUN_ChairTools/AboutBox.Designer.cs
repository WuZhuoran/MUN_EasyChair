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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.panelAuthorization = new System.Windows.Forms.Panel();
            this.linkLabelMyGithubAddress = new System.Windows.Forms.LinkLabel();
            this.labelProductStatement = new System.Windows.Forms.Label();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductVersion = new System.Windows.Forms.Label();
            this.labelProdectOwner = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.buttonCppyRightText = new System.Windows.Forms.Button();
            this.pictureBoxUNFlag = new System.Windows.Forms.PictureBox();
            this.labelContactWriter = new System.Windows.Forms.Label();
            this.linkLabelWriterEmail = new System.Windows.Forms.LinkLabel();
            this.buttonGPLlicense = new System.Windows.Forms.Button();
            this.panelAuthorization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUNFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAuthorization
            // 
            this.panelAuthorization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAuthorization.Controls.Add(this.linkLabelMyGithubAddress);
            this.panelAuthorization.Controls.Add(this.labelProductStatement);
            this.panelAuthorization.Controls.Add(this.labelAuthorization);
            resources.ApplyResources(this.panelAuthorization, "panelAuthorization");
            this.panelAuthorization.Name = "panelAuthorization";
            // 
            // linkLabelMyGithubAddress
            // 
            resources.ApplyResources(this.linkLabelMyGithubAddress, "linkLabelMyGithubAddress");
            this.linkLabelMyGithubAddress.Name = "linkLabelMyGithubAddress";
            this.linkLabelMyGithubAddress.TabStop = true;
            // 
            // labelProductStatement
            // 
            resources.ApplyResources(this.labelProductStatement, "labelProductStatement");
            this.labelProductStatement.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelProductStatement.Name = "labelProductStatement";
            // 
            // labelAuthorization
            // 
            resources.ApplyResources(this.labelAuthorization, "labelAuthorization");
            this.labelAuthorization.Name = "labelAuthorization";
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelProductName
            // 
            resources.ApplyResources(this.labelProductName, "labelProductName");
            this.labelProductName.Name = "labelProductName";
            // 
            // labelProductVersion
            // 
            resources.ApplyResources(this.labelProductVersion, "labelProductVersion");
            this.labelProductVersion.Name = "labelProductVersion";
            // 
            // labelProdectOwner
            // 
            resources.ApplyResources(this.labelProdectOwner, "labelProdectOwner");
            this.labelProdectOwner.Name = "labelProdectOwner";
            // 
            // labelWarning
            // 
            resources.ApplyResources(this.labelWarning, "labelWarning");
            this.labelWarning.Name = "labelWarning";
            // 
            // buttonCppyRightText
            // 
            resources.ApplyResources(this.buttonCppyRightText, "buttonCppyRightText");
            this.buttonCppyRightText.Name = "buttonCppyRightText";
            this.buttonCppyRightText.UseVisualStyleBackColor = true;
            this.buttonCppyRightText.Click += new System.EventHandler(this.buttonCppyRightText_Click);
            // 
            // pictureBoxUNFlag
            // 
            this.pictureBoxUNFlag.Image = global::MUN_ChairTools.Properties.Resources.UnitedNationFlag;
            resources.ApplyResources(this.pictureBoxUNFlag, "pictureBoxUNFlag");
            this.pictureBoxUNFlag.Name = "pictureBoxUNFlag";
            this.pictureBoxUNFlag.TabStop = false;
            // 
            // labelContactWriter
            // 
            resources.ApplyResources(this.labelContactWriter, "labelContactWriter");
            this.labelContactWriter.Name = "labelContactWriter";
            // 
            // linkLabelWriterEmail
            // 
            resources.ApplyResources(this.linkLabelWriterEmail, "linkLabelWriterEmail");
            this.linkLabelWriterEmail.Name = "linkLabelWriterEmail";
            this.linkLabelWriterEmail.TabStop = true;
            // 
            // buttonGPLlicense
            // 
            resources.ApplyResources(this.buttonGPLlicense, "buttonGPLlicense");
            this.buttonGPLlicense.Name = "buttonGPLlicense";
            this.buttonGPLlicense.UseVisualStyleBackColor = true;
            this.buttonGPLlicense.Click += new System.EventHandler(this.buttonGPLlicense_Click);
            // 
            // AboutBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonGPLlicense);
            this.Controls.Add(this.linkLabelWriterEmail);
            this.Controls.Add(this.labelContactWriter);
            this.Controls.Add(this.buttonCppyRightText);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.labelProdectOwner);
            this.Controls.Add(this.labelProductVersion);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panelAuthorization);
            this.Controls.Add(this.pictureBoxUNFlag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.panelAuthorization.ResumeLayout(false);
            this.panelAuthorization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUNFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUNFlag;
        private System.Windows.Forms.Panel panelAuthorization;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductVersion;
        private System.Windows.Forms.Label labelProdectOwner;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.Label labelProductStatement;
        private System.Windows.Forms.LinkLabel linkLabelMyGithubAddress;
        private System.Windows.Forms.Button buttonCppyRightText;
        private System.Windows.Forms.Label labelContactWriter;
        private System.Windows.Forms.LinkLabel linkLabelWriterEmail;
        private System.Windows.Forms.Button buttonGPLlicense;

    }
}
