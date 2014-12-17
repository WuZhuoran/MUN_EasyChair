namespace MUN_ChairTools
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSpeakersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.动议结束辩论ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.动议投票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他动议ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RollCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OtherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeeHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelConferenceInformation = new System.Windows.Forms.Label();
            this.comboBoxChooseCountry = new System.Windows.Forms.ComboBox();
            this.pictureBoxCountryPlus = new System.Windows.Forms.PictureBox();
            this.pictureBoxCountryMinus = new System.Windows.Forms.PictureBox();
            this.listBoxSpeakersList = new System.Windows.Forms.ListBox();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.labelSetTimeMinute = new System.Windows.Forms.Label();
            this.buttonSetTimeReset = new System.Windows.Forms.Button();
            this.buttonSetTimePause = new System.Windows.Forms.Button();
            this.buttonSetTimeStart = new System.Windows.Forms.Button();
            this.LabelSecond = new System.Windows.Forms.Label();
            this.numericUpDownSetTime = new System.Windows.Forms.NumericUpDown();
            this.labelSetTime = new System.Windows.Forms.Label();
            this.labelSystemTime = new System.Windows.Forms.Label();
            this.groupBoxRecord = new System.Windows.Forms.GroupBox();
            this.richTextBoxRecord = new System.Windows.Forms.RichTextBox();
            this.timerSetTime = new System.Windows.Forms.Timer(this.components);
            this.timerSystemTime = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountryPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountryMinus)).BeginInit();
            this.groupBoxTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetTime)).BeginInit();
            this.groupBoxRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            resources.ApplyResources(this.menuStripMain, "menuStripMain");
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemToolStripMenuItem,
            this.ActionToolStripMenuItem,
            this.OtherToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStripMain.Name = "menuStripMain";
            // 
            // SystemToolStripMenuItem
            // 
            resources.ApplyResources(this.SystemToolStripMenuItem, "SystemToolStripMenuItem");
            this.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
            // 
            // ActionToolStripMenuItem
            // 
            resources.ApplyResources(this.ActionToolStripMenuItem, "ActionToolStripMenuItem");
            this.ActionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MotionToolStripMenuItem,
            this.RollCallToolStripMenuItem});
            this.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem";
            // 
            // MotionToolStripMenuItem
            // 
            resources.ApplyResources(this.MotionToolStripMenuItem, "MotionToolStripMenuItem");
            this.MotionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MCToolStripMenuItem,
            this.UMCToolStripMenuItem,
            this.SuspendToolStripMenuItem,
            this.OpenSpeakersListToolStripMenuItem,
            this.动议结束辩论ToolStripMenuItem,
            this.动议投票ToolStripMenuItem,
            this.其他动议ToolStripMenuItem});
            this.MotionToolStripMenuItem.Name = "MotionToolStripMenuItem";
            // 
            // MCToolStripMenuItem
            // 
            resources.ApplyResources(this.MCToolStripMenuItem, "MCToolStripMenuItem");
            this.MCToolStripMenuItem.Name = "MCToolStripMenuItem";
            this.MCToolStripMenuItem.Click += new System.EventHandler(this.MCToolStripMenuItem_Click);
            // 
            // UMCToolStripMenuItem
            // 
            resources.ApplyResources(this.UMCToolStripMenuItem, "UMCToolStripMenuItem");
            this.UMCToolStripMenuItem.Name = "UMCToolStripMenuItem";
            this.UMCToolStripMenuItem.Click += new System.EventHandler(this.UMCToolStripMenuItem_Click);
            // 
            // SuspendToolStripMenuItem
            // 
            resources.ApplyResources(this.SuspendToolStripMenuItem, "SuspendToolStripMenuItem");
            this.SuspendToolStripMenuItem.Name = "SuspendToolStripMenuItem";
            // 
            // OpenSpeakersListToolStripMenuItem
            // 
            resources.ApplyResources(this.OpenSpeakersListToolStripMenuItem, "OpenSpeakersListToolStripMenuItem");
            this.OpenSpeakersListToolStripMenuItem.Name = "OpenSpeakersListToolStripMenuItem";
            this.OpenSpeakersListToolStripMenuItem.Click += new System.EventHandler(this.OpenSpeakersListToolStripMenuItem_Click);
            // 
            // 动议结束辩论ToolStripMenuItem
            // 
            resources.ApplyResources(this.动议结束辩论ToolStripMenuItem, "动议结束辩论ToolStripMenuItem");
            this.动议结束辩论ToolStripMenuItem.Name = "动议结束辩论ToolStripMenuItem";
            // 
            // 动议投票ToolStripMenuItem
            // 
            resources.ApplyResources(this.动议投票ToolStripMenuItem, "动议投票ToolStripMenuItem");
            this.动议投票ToolStripMenuItem.Name = "动议投票ToolStripMenuItem";
            // 
            // 其他动议ToolStripMenuItem
            // 
            resources.ApplyResources(this.其他动议ToolStripMenuItem, "其他动议ToolStripMenuItem");
            this.其他动议ToolStripMenuItem.Name = "其他动议ToolStripMenuItem";
            // 
            // RollCallToolStripMenuItem
            // 
            resources.ApplyResources(this.RollCallToolStripMenuItem, "RollCallToolStripMenuItem");
            this.RollCallToolStripMenuItem.Name = "RollCallToolStripMenuItem";
            this.RollCallToolStripMenuItem.Click += new System.EventHandler(this.RollCallToolStripMenuItem_Click);
            // 
            // OtherToolStripMenuItem
            // 
            resources.ApplyResources(this.OtherToolStripMenuItem, "OtherToolStripMenuItem");
            this.OtherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem});
            this.OtherToolStripMenuItem.Name = "OtherToolStripMenuItem";
            // 
            // SettingsToolStripMenuItem
            // 
            resources.ApplyResources(this.SettingsToolStripMenuItem, "SettingsToolStripMenuItem");
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            // 
            // HelpToolStripMenuItem
            // 
            resources.ApplyResources(this.HelpToolStripMenuItem, "HelpToolStripMenuItem");
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SeeHelpToolStripMenuItem,
            this.AboutBoxToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            // 
            // SeeHelpToolStripMenuItem
            // 
            resources.ApplyResources(this.SeeHelpToolStripMenuItem, "SeeHelpToolStripMenuItem");
            this.SeeHelpToolStripMenuItem.Name = "SeeHelpToolStripMenuItem";
            // 
            // AboutBoxToolStripMenuItem
            // 
            resources.ApplyResources(this.AboutBoxToolStripMenuItem, "AboutBoxToolStripMenuItem");
            this.AboutBoxToolStripMenuItem.Name = "AboutBoxToolStripMenuItem";
            this.AboutBoxToolStripMenuItem.Click += new System.EventHandler(this.AboutBoxToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Controls.Add(this.groupBoxInfo);
            this.panelMain.Controls.Add(this.groupBoxTime);
            this.panelMain.Controls.Add(this.groupBoxRecord);
            this.panelMain.Name = "panelMain";
            this.panelMain.SizeChanged += new System.EventHandler(this.panelMain_SizeChanged);
            // 
            // groupBoxInfo
            // 
            resources.ApplyResources(this.groupBoxInfo, "groupBoxInfo");
            this.groupBoxInfo.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxInfo.Controls.Add(this.labelConferenceInformation);
            this.groupBoxInfo.Controls.Add(this.comboBoxChooseCountry);
            this.groupBoxInfo.Controls.Add(this.pictureBoxCountryPlus);
            this.groupBoxInfo.Controls.Add(this.pictureBoxCountryMinus);
            this.groupBoxInfo.Controls.Add(this.listBoxSpeakersList);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.TabStop = false;
            // 
            // labelConferenceInformation
            // 
            resources.ApplyResources(this.labelConferenceInformation, "labelConferenceInformation");
            this.labelConferenceInformation.Name = "labelConferenceInformation";
            // 
            // comboBoxChooseCountry
            // 
            resources.ApplyResources(this.comboBoxChooseCountry, "comboBoxChooseCountry");
            this.comboBoxChooseCountry.FormattingEnabled = true;
            this.comboBoxChooseCountry.Name = "comboBoxChooseCountry";
            // 
            // pictureBoxCountryPlus
            // 
            resources.ApplyResources(this.pictureBoxCountryPlus, "pictureBoxCountryPlus");
            this.pictureBoxCountryPlus.Image = global::MUN_ChairTools.Properties.Resources.plus;
            this.pictureBoxCountryPlus.Name = "pictureBoxCountryPlus";
            this.pictureBoxCountryPlus.TabStop = false;
            this.pictureBoxCountryPlus.Click += new System.EventHandler(this.pictureBoxCountryPlus_Click);
            // 
            // pictureBoxCountryMinus
            // 
            resources.ApplyResources(this.pictureBoxCountryMinus, "pictureBoxCountryMinus");
            this.pictureBoxCountryMinus.Image = global::MUN_ChairTools.Properties.Resources.minus;
            this.pictureBoxCountryMinus.Name = "pictureBoxCountryMinus";
            this.pictureBoxCountryMinus.TabStop = false;
            this.pictureBoxCountryMinus.Click += new System.EventHandler(this.pictureBoxCountryMinus_Click);
            // 
            // listBoxSpeakersList
            // 
            resources.ApplyResources(this.listBoxSpeakersList, "listBoxSpeakersList");
            this.listBoxSpeakersList.FormattingEnabled = true;
            this.listBoxSpeakersList.Name = "listBoxSpeakersList";
            // 
            // groupBoxTime
            // 
            resources.ApplyResources(this.groupBoxTime, "groupBoxTime");
            this.groupBoxTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxTime.Controls.Add(this.labelSetTimeMinute);
            this.groupBoxTime.Controls.Add(this.buttonSetTimeReset);
            this.groupBoxTime.Controls.Add(this.buttonSetTimePause);
            this.groupBoxTime.Controls.Add(this.buttonSetTimeStart);
            this.groupBoxTime.Controls.Add(this.LabelSecond);
            this.groupBoxTime.Controls.Add(this.numericUpDownSetTime);
            this.groupBoxTime.Controls.Add(this.labelSetTime);
            this.groupBoxTime.Controls.Add(this.labelSystemTime);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.TabStop = false;
            // 
            // labelSetTimeMinute
            // 
            resources.ApplyResources(this.labelSetTimeMinute, "labelSetTimeMinute");
            this.labelSetTimeMinute.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSetTimeMinute.Name = "labelSetTimeMinute";
            // 
            // buttonSetTimeReset
            // 
            resources.ApplyResources(this.buttonSetTimeReset, "buttonSetTimeReset");
            this.buttonSetTimeReset.Name = "buttonSetTimeReset";
            this.buttonSetTimeReset.UseVisualStyleBackColor = true;
            this.buttonSetTimeReset.Click += new System.EventHandler(this.buttonSetTimeReset_Click);
            // 
            // buttonSetTimePause
            // 
            resources.ApplyResources(this.buttonSetTimePause, "buttonSetTimePause");
            this.buttonSetTimePause.Name = "buttonSetTimePause";
            this.buttonSetTimePause.UseVisualStyleBackColor = true;
            this.buttonSetTimePause.Click += new System.EventHandler(this.buttonSetTimePause_Click);
            // 
            // buttonSetTimeStart
            // 
            resources.ApplyResources(this.buttonSetTimeStart, "buttonSetTimeStart");
            this.buttonSetTimeStart.Name = "buttonSetTimeStart";
            this.buttonSetTimeStart.UseVisualStyleBackColor = true;
            this.buttonSetTimeStart.Click += new System.EventHandler(this.buttonSetTimeStart_Click);
            // 
            // LabelSecond
            // 
            resources.ApplyResources(this.LabelSecond, "LabelSecond");
            this.LabelSecond.Name = "LabelSecond";
            // 
            // numericUpDownSetTime
            // 
            resources.ApplyResources(this.numericUpDownSetTime, "numericUpDownSetTime");
            this.numericUpDownSetTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownSetTime.Name = "numericUpDownSetTime";
            // 
            // labelSetTime
            // 
            resources.ApplyResources(this.labelSetTime, "labelSetTime");
            this.labelSetTime.Name = "labelSetTime";
            // 
            // labelSystemTime
            // 
            resources.ApplyResources(this.labelSystemTime, "labelSystemTime");
            this.labelSystemTime.Name = "labelSystemTime";
            // 
            // groupBoxRecord
            // 
            resources.ApplyResources(this.groupBoxRecord, "groupBoxRecord");
            this.groupBoxRecord.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBoxRecord.Controls.Add(this.richTextBoxRecord);
            this.groupBoxRecord.Name = "groupBoxRecord";
            this.groupBoxRecord.TabStop = false;
            // 
            // richTextBoxRecord
            // 
            resources.ApplyResources(this.richTextBoxRecord, "richTextBoxRecord");
            this.richTextBoxRecord.Name = "richTextBoxRecord";
            // 
            // timerSetTime
            // 
            this.timerSetTime.Interval = 1000;
            // 
            // timerSystemTime
            // 
            this.timerSystemTime.Interval = 1000;
            this.timerSystemTime.Tick += new System.EventHandler(this.timerSystemTime_Tick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStripMain);
            this.Name = "MainForm";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountryPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountryMinus)).EndInit();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetTime)).EndInit();
            this.groupBoxRecord.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem SystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ActionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OtherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBoxRecord;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelSystemTime;
        private System.Windows.Forms.Label labelSetTime;
        private System.Windows.Forms.Label LabelSecond;
        private System.Windows.Forms.NumericUpDown numericUpDownSetTime;
        private System.Windows.Forms.Button buttonSetTimePause;
        private System.Windows.Forms.Button buttonSetTimeStart;
        private System.Windows.Forms.Label labelSetTimeMinute;
        private System.Windows.Forms.Button buttonSetTimeReset;
        private System.Windows.Forms.ToolStripMenuItem SeeHelpToolStripMenuItem;
        private System.Windows.Forms.Timer timerSetTime;
        private System.Windows.Forms.Timer timerSystemTime;
        private System.Windows.Forms.ToolStripMenuItem AboutBoxToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxRecord;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SuspendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenSpeakersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 动议结束辩论ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 动议投票ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他动议ToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxSpeakersList;
        private System.Windows.Forms.PictureBox pictureBoxCountryMinus;
        private System.Windows.Forms.PictureBox pictureBoxCountryPlus;
        private System.Windows.Forms.ComboBox comboBoxChooseCountry;
        private System.Windows.Forms.Label labelConferenceInformation;
        private System.Windows.Forms.ToolStripMenuItem RollCallToolStripMenuItem;
    }
}

