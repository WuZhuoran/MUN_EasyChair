namespace MUN_ChairTools
{
    partial class ConferenceLoadAndInit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConferenceLoadAndInit));
            this.labelConferenceName = new System.Windows.Forms.Label();
            this.textBoxConferenceName = new System.Windows.Forms.TextBox();
            this.labelCommitteeName = new System.Windows.Forms.Label();
            this.textBoxCommitteeName = new System.Windows.Forms.TextBox();
            this.labelOfficialLanguage = new System.Windows.Forms.Label();
            this.comboBoxOfficialLanguage = new System.Windows.Forms.ComboBox();
            this.buttonAddCountry = new System.Windows.Forms.Button();
            this.buttonLoadFileData = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxConferenceLogo = new System.Windows.Forms.PictureBox();
            this.labelConferenceInitial = new System.Windows.Forms.Label();
            this.labelCountryNumber = new System.Windows.Forms.Label();
            this.numericUpDownCountryNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConferenceLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountryNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConferenceName
            // 
            this.labelConferenceName.AutoSize = true;
            this.labelConferenceName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelConferenceName.Location = new System.Drawing.Point(32, 70);
            this.labelConferenceName.Name = "labelConferenceName";
            this.labelConferenceName.Size = new System.Drawing.Size(117, 28);
            this.labelConferenceName.TabIndex = 0;
            this.labelConferenceName.Text = "会议名称：";
            // 
            // textBoxConferenceName
            // 
            this.textBoxConferenceName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBoxConferenceName.Location = new System.Drawing.Point(185, 63);
            this.textBoxConferenceName.Name = "textBoxConferenceName";
            this.textBoxConferenceName.Size = new System.Drawing.Size(320, 35);
            this.textBoxConferenceName.TabIndex = 1;
            // 
            // labelCommitteeName
            // 
            this.labelCommitteeName.AutoSize = true;
            this.labelCommitteeName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCommitteeName.Location = new System.Drawing.Point(32, 117);
            this.labelCommitteeName.Name = "labelCommitteeName";
            this.labelCommitteeName.Size = new System.Drawing.Size(138, 28);
            this.labelCommitteeName.TabIndex = 2;
            this.labelCommitteeName.Text = "委员会名称：";
            // 
            // textBoxCommitteeName
            // 
            this.textBoxCommitteeName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBoxCommitteeName.Location = new System.Drawing.Point(185, 110);
            this.textBoxCommitteeName.Name = "textBoxCommitteeName";
            this.textBoxCommitteeName.Size = new System.Drawing.Size(320, 35);
            this.textBoxCommitteeName.TabIndex = 3;
            // 
            // labelOfficialLanguage
            // 
            this.labelOfficialLanguage.AutoSize = true;
            this.labelOfficialLanguage.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOfficialLanguage.Location = new System.Drawing.Point(32, 205);
            this.labelOfficialLanguage.Name = "labelOfficialLanguage";
            this.labelOfficialLanguage.Size = new System.Drawing.Size(159, 28);
            this.labelOfficialLanguage.TabIndex = 4;
            this.labelOfficialLanguage.Text = "会议工作语言：";
            // 
            // comboBoxOfficialLanguage
            // 
            this.comboBoxOfficialLanguage.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxOfficialLanguage.FormattingEnabled = true;
            this.comboBoxOfficialLanguage.Items.AddRange(new object[] {
            "中文",
            "英文",
            "其他"});
            this.comboBoxOfficialLanguage.Location = new System.Drawing.Point(185, 197);
            this.comboBoxOfficialLanguage.Name = "comboBoxOfficialLanguage";
            this.comboBoxOfficialLanguage.Size = new System.Drawing.Size(320, 36);
            this.comboBoxOfficialLanguage.TabIndex = 5;
            // 
            // buttonAddCountry
            // 
            this.buttonAddCountry.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonAddCountry.Location = new System.Drawing.Point(163, 267);
            this.buttonAddCountry.Name = "buttonAddCountry";
            this.buttonAddCountry.Size = new System.Drawing.Size(104, 51);
            this.buttonAddCountry.TabIndex = 6;
            this.buttonAddCountry.Text = "添加国家";
            this.buttonAddCountry.UseVisualStyleBackColor = true;
            this.buttonAddCountry.Click += new System.EventHandler(this.buttonAddCountry_Click);
            // 
            // buttonLoadFileData
            // 
            this.buttonLoadFileData.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonLoadFileData.Location = new System.Drawing.Point(37, 267);
            this.buttonLoadFileData.Name = "buttonLoadFileData";
            this.buttonLoadFileData.Size = new System.Drawing.Size(112, 51);
            this.buttonLoadFileData.TabIndex = 7;
            this.buttonLoadFileData.Text = "加载文件";
            this.buttonLoadFileData.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonConfirm.Location = new System.Drawing.Point(282, 267);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(104, 51);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "确定";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(401, 267);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(104, 51);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxConferenceLogo
            // 
            this.pictureBoxConferenceLogo.Image = global::MUN_ChairTools.Properties.Resources.UnitedNationFlag;
            this.pictureBoxConferenceLogo.Location = new System.Drawing.Point(511, 63);
            this.pictureBoxConferenceLogo.Name = "pictureBoxConferenceLogo";
            this.pictureBoxConferenceLogo.Size = new System.Drawing.Size(361, 255);
            this.pictureBoxConferenceLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConferenceLogo.TabIndex = 10;
            this.pictureBoxConferenceLogo.TabStop = false;
            // 
            // labelConferenceInitial
            // 
            this.labelConferenceInitial.AutoSize = true;
            this.labelConferenceInitial.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelConferenceInitial.Location = new System.Drawing.Point(340, 9);
            this.labelConferenceInitial.Name = "labelConferenceInitial";
            this.labelConferenceInitial.Size = new System.Drawing.Size(200, 35);
            this.labelConferenceInitial.TabIndex = 11;
            this.labelConferenceInitial.Text = "会议初始化";
            // 
            // labelCountryNumber
            // 
            this.labelCountryNumber.AutoSize = true;
            this.labelCountryNumber.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCountryNumber.Location = new System.Drawing.Point(32, 161);
            this.labelCountryNumber.Name = "labelCountryNumber";
            this.labelCountryNumber.Size = new System.Drawing.Size(117, 28);
            this.labelCountryNumber.TabIndex = 12;
            this.labelCountryNumber.Text = "国家数量：";
            // 
            // numericUpDownCountryNumber
            // 
            this.numericUpDownCountryNumber.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDownCountryNumber.Location = new System.Drawing.Point(185, 154);
            this.numericUpDownCountryNumber.Name = "numericUpDownCountryNumber";
            this.numericUpDownCountryNumber.Size = new System.Drawing.Size(320, 35);
            this.numericUpDownCountryNumber.TabIndex = 13;
            // 
            // ConferenceLoadAndInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.numericUpDownCountryNumber);
            this.Controls.Add(this.labelCountryNumber);
            this.Controls.Add(this.labelConferenceInitial);
            this.Controls.Add(this.pictureBoxConferenceLogo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonLoadFileData);
            this.Controls.Add(this.buttonAddCountry);
            this.Controls.Add(this.comboBoxOfficialLanguage);
            this.Controls.Add(this.labelOfficialLanguage);
            this.Controls.Add(this.textBoxCommitteeName);
            this.Controls.Add(this.labelCommitteeName);
            this.Controls.Add(this.textBoxConferenceName);
            this.Controls.Add(this.labelConferenceName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConferenceLoadAndInit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConferenceLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountryNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConferenceName;
        private System.Windows.Forms.TextBox textBoxConferenceName;
        private System.Windows.Forms.Label labelCommitteeName;
        private System.Windows.Forms.TextBox textBoxCommitteeName;
        private System.Windows.Forms.Label labelOfficialLanguage;
        private System.Windows.Forms.ComboBox comboBoxOfficialLanguage;
        private System.Windows.Forms.Button buttonAddCountry;
        private System.Windows.Forms.Button buttonLoadFileData;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxConferenceLogo;
        private System.Windows.Forms.Label labelConferenceInitial;
        private System.Windows.Forms.Label labelCountryNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownCountryNumber;
    }
}