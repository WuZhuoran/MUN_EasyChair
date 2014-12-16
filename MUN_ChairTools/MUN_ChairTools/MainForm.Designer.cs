﻿namespace MUN_ChairTools
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
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemToolStripMenuItem,
            this.ActionToolStripMenuItem,
            this.OtherToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1008, 24);
            this.menuStripMain.TabIndex = 3;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // SystemToolStripMenuItem
            // 
            this.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
            this.SystemToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.SystemToolStripMenuItem.Text = "文件";
            // 
            // ActionToolStripMenuItem
            // 
            this.ActionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MotionToolStripMenuItem,
            this.RollCallToolStripMenuItem});
            this.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem";
            this.ActionToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.ActionToolStripMenuItem.Text = "操作";
            // 
            // MotionToolStripMenuItem
            // 
            this.MotionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MCToolStripMenuItem,
            this.UMCToolStripMenuItem,
            this.SuspendToolStripMenuItem,
            this.OpenSpeakersListToolStripMenuItem,
            this.动议结束辩论ToolStripMenuItem,
            this.动议投票ToolStripMenuItem,
            this.其他动议ToolStripMenuItem});
            this.MotionToolStripMenuItem.Name = "MotionToolStripMenuItem";
            this.MotionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.MotionToolStripMenuItem.Text = "动议";
            // 
            // MCToolStripMenuItem
            // 
            this.MCToolStripMenuItem.Name = "MCToolStripMenuItem";
            this.MCToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.MCToolStripMenuItem.Text = "有主持核心磋商";
            this.MCToolStripMenuItem.Click += new System.EventHandler(this.MCToolStripMenuItem_Click);
            // 
            // UMCToolStripMenuItem
            // 
            this.UMCToolStripMenuItem.Name = "UMCToolStripMenuItem";
            this.UMCToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.UMCToolStripMenuItem.Text = "无主持核心磋商";
            this.UMCToolStripMenuItem.Click += new System.EventHandler(this.UMCToolStripMenuItem_Click);
            // 
            // SuspendToolStripMenuItem
            // 
            this.SuspendToolStripMenuItem.Name = "SuspendToolStripMenuItem";
            this.SuspendToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.SuspendToolStripMenuItem.Text = "动议休会";
            // 
            // OpenSpeakersListToolStripMenuItem
            // 
            this.OpenSpeakersListToolStripMenuItem.Name = "OpenSpeakersListToolStripMenuItem";
            this.OpenSpeakersListToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.OpenSpeakersListToolStripMenuItem.Text = "动议开启主发言名单";
            this.OpenSpeakersListToolStripMenuItem.Click += new System.EventHandler(this.OpenSpeakersListToolStripMenuItem_Click);
            // 
            // 动议结束辩论ToolStripMenuItem
            // 
            this.动议结束辩论ToolStripMenuItem.Name = "动议结束辩论ToolStripMenuItem";
            this.动议结束辩论ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.动议结束辩论ToolStripMenuItem.Text = "动议结束辩论";
            // 
            // 动议投票ToolStripMenuItem
            // 
            this.动议投票ToolStripMenuItem.Name = "动议投票ToolStripMenuItem";
            this.动议投票ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.动议投票ToolStripMenuItem.Text = "动议投票";
            // 
            // 其他动议ToolStripMenuItem
            // 
            this.其他动议ToolStripMenuItem.Name = "其他动议ToolStripMenuItem";
            this.其他动议ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.其他动议ToolStripMenuItem.Text = "其他动议";
            // 
            // RollCallToolStripMenuItem
            // 
            this.RollCallToolStripMenuItem.Name = "RollCallToolStripMenuItem";
            this.RollCallToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RollCallToolStripMenuItem.Text = "点名";
            this.RollCallToolStripMenuItem.Click += new System.EventHandler(this.RollCallToolStripMenuItem_Click);
            // 
            // OtherToolStripMenuItem
            // 
            this.OtherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem});
            this.OtherToolStripMenuItem.Name = "OtherToolStripMenuItem";
            this.OtherToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.OtherToolStripMenuItem.Text = "其他";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SettingsToolStripMenuItem.Text = "会议设定";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SeeHelpToolStripMenuItem,
            this.AboutBoxToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.HelpToolStripMenuItem.Text = "帮助";
            // 
            // SeeHelpToolStripMenuItem
            // 
            this.SeeHelpToolStripMenuItem.Name = "SeeHelpToolStripMenuItem";
            this.SeeHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SeeHelpToolStripMenuItem.Text = "帮助";
            // 
            // AboutBoxToolStripMenuItem
            // 
            this.AboutBoxToolStripMenuItem.Name = "AboutBoxToolStripMenuItem";
            this.AboutBoxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AboutBoxToolStripMenuItem.Text = "关于";
            this.AboutBoxToolStripMenuItem.Click += new System.EventHandler(this.AboutBoxToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Controls.Add(this.groupBoxInfo);
            this.panelMain.Controls.Add(this.groupBoxTime);
            this.panelMain.Controls.Add(this.groupBoxRecord);
            this.panelMain.Location = new System.Drawing.Point(12, 28);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(984, 690);
            this.panelMain.TabIndex = 4;
            this.panelMain.SizeChanged += new System.EventHandler(this.panelMain_SizeChanged);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxInfo.Controls.Add(this.labelConferenceInformation);
            this.groupBoxInfo.Controls.Add(this.comboBoxChooseCountry);
            this.groupBoxInfo.Controls.Add(this.pictureBoxCountryPlus);
            this.groupBoxInfo.Controls.Add(this.pictureBoxCountryMinus);
            this.groupBoxInfo.Controls.Add(this.listBoxSpeakersList);
            this.groupBoxInfo.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(589, 263);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(400, 352);
            this.groupBoxInfo.TabIndex = 2;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "信息";
            // 
            // labelConferenceInformation
            // 
            this.labelConferenceInformation.AutoSize = true;
            this.labelConferenceInformation.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelConferenceInformation.Location = new System.Drawing.Point(210, 40);
            this.labelConferenceInformation.Name = "labelConferenceInformation";
            this.labelConferenceInformation.Size = new System.Drawing.Size(88, 26);
            this.labelConferenceInformation.TabIndex = 4;
            this.labelConferenceInformation.Text = "会议信息";
            // 
            // comboBoxChooseCountry
            // 
            this.comboBoxChooseCountry.FormattingEnabled = true;
            this.comboBoxChooseCountry.Location = new System.Drawing.Point(9, 310);
            this.comboBoxChooseCountry.Name = "comboBoxChooseCountry";
            this.comboBoxChooseCountry.Size = new System.Drawing.Size(121, 37);
            this.comboBoxChooseCountry.TabIndex = 3;
            // 
            // pictureBoxCountryPlus
            // 
            this.pictureBoxCountryPlus.Image = global::MUN_ChairTools.Properties.Resources.plus;
            this.pictureBoxCountryPlus.Location = new System.Drawing.Point(136, 310);
            this.pictureBoxCountryPlus.Name = "pictureBoxCountryPlus";
            this.pictureBoxCountryPlus.Size = new System.Drawing.Size(31, 33);
            this.pictureBoxCountryPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCountryPlus.TabIndex = 2;
            this.pictureBoxCountryPlus.TabStop = false;
            this.pictureBoxCountryPlus.Click += new System.EventHandler(this.pictureBoxCountryPlus_Click);
            // 
            // pictureBoxCountryMinus
            // 
            this.pictureBoxCountryMinus.Image = global::MUN_ChairTools.Properties.Resources.minus;
            this.pictureBoxCountryMinus.Location = new System.Drawing.Point(173, 310);
            this.pictureBoxCountryMinus.Name = "pictureBoxCountryMinus";
            this.pictureBoxCountryMinus.Size = new System.Drawing.Size(31, 33);
            this.pictureBoxCountryMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCountryMinus.TabIndex = 1;
            this.pictureBoxCountryMinus.TabStop = false;
            this.pictureBoxCountryMinus.Click += new System.EventHandler(this.pictureBoxCountryMinus_Click);
            // 
            // listBoxSpeakersList
            // 
            this.listBoxSpeakersList.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.listBoxSpeakersList.FormattingEnabled = true;
            this.listBoxSpeakersList.ItemHeight = 26;
            this.listBoxSpeakersList.Location = new System.Drawing.Point(9, 40);
            this.listBoxSpeakersList.Name = "listBoxSpeakersList";
            this.listBoxSpeakersList.Size = new System.Drawing.Size(195, 264);
            this.listBoxSpeakersList.TabIndex = 0;
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxTime.Controls.Add(this.labelSetTimeMinute);
            this.groupBoxTime.Controls.Add(this.buttonSetTimeReset);
            this.groupBoxTime.Controls.Add(this.buttonSetTimePause);
            this.groupBoxTime.Controls.Add(this.buttonSetTimeStart);
            this.groupBoxTime.Controls.Add(this.LabelSecond);
            this.groupBoxTime.Controls.Add(this.numericUpDownSetTime);
            this.groupBoxTime.Controls.Add(this.labelSetTime);
            this.groupBoxTime.Controls.Add(this.labelSystemTime);
            this.groupBoxTime.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxTime.Location = new System.Drawing.Point(589, 3);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(400, 250);
            this.groupBoxTime.TabIndex = 1;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "计时工具";
            // 
            // labelSetTimeMinute
            // 
            this.labelSetTimeMinute.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSetTimeMinute.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSetTimeMinute.Location = new System.Drawing.Point(26, 71);
            this.labelSetTimeMinute.Name = "labelSetTimeMinute";
            this.labelSetTimeMinute.Size = new System.Drawing.Size(335, 128);
            this.labelSetTimeMinute.TabIndex = 6;
            this.labelSetTimeMinute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSetTimeReset
            // 
            this.buttonSetTimeReset.Font = new System.Drawing.Font("宋体", 9F);
            this.buttonSetTimeReset.Location = new System.Drawing.Point(331, 209);
            this.buttonSetTimeReset.Name = "buttonSetTimeReset";
            this.buttonSetTimeReset.Size = new System.Drawing.Size(44, 33);
            this.buttonSetTimeReset.TabIndex = 9;
            this.buttonSetTimeReset.Text = "重置";
            this.buttonSetTimeReset.UseVisualStyleBackColor = true;
            this.buttonSetTimeReset.Click += new System.EventHandler(this.buttonSetTimeReset_Click);
            // 
            // buttonSetTimePause
            // 
            this.buttonSetTimePause.Font = new System.Drawing.Font("宋体", 9F);
            this.buttonSetTimePause.Location = new System.Drawing.Point(281, 209);
            this.buttonSetTimePause.Name = "buttonSetTimePause";
            this.buttonSetTimePause.Size = new System.Drawing.Size(44, 33);
            this.buttonSetTimePause.TabIndex = 5;
            this.buttonSetTimePause.Text = "暂停";
            this.buttonSetTimePause.UseVisualStyleBackColor = true;
            this.buttonSetTimePause.Click += new System.EventHandler(this.buttonSetTimePause_Click);
            // 
            // buttonSetTimeStart
            // 
            this.buttonSetTimeStart.Font = new System.Drawing.Font("宋体", 9F);
            this.buttonSetTimeStart.Location = new System.Drawing.Point(229, 209);
            this.buttonSetTimeStart.Name = "buttonSetTimeStart";
            this.buttonSetTimeStart.Size = new System.Drawing.Size(46, 33);
            this.buttonSetTimeStart.TabIndex = 4;
            this.buttonSetTimeStart.Text = "开始";
            this.buttonSetTimeStart.UseVisualStyleBackColor = true;
            this.buttonSetTimeStart.Click += new System.EventHandler(this.buttonSetTimeStart_Click);
            // 
            // LabelSecond
            // 
            this.LabelSecond.AutoSize = true;
            this.LabelSecond.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.LabelSecond.Location = new System.Drawing.Point(192, 211);
            this.LabelSecond.Name = "LabelSecond";
            this.LabelSecond.Size = new System.Drawing.Size(31, 26);
            this.LabelSecond.TabIndex = 3;
            this.LabelSecond.Text = "秒";
            // 
            // numericUpDownSetTime
            // 
            this.numericUpDownSetTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.numericUpDownSetTime.Location = new System.Drawing.Point(117, 209);
            this.numericUpDownSetTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownSetTime.Name = "numericUpDownSetTime";
            this.numericUpDownSetTime.Size = new System.Drawing.Size(69, 33);
            this.numericUpDownSetTime.TabIndex = 2;
            // 
            // labelSetTime
            // 
            this.labelSetTime.AutoSize = true;
            this.labelSetTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSetTime.Location = new System.Drawing.Point(18, 211);
            this.labelSetTime.Name = "labelSetTime";
            this.labelSetTime.Size = new System.Drawing.Size(107, 26);
            this.labelSetTime.TabIndex = 1;
            this.labelSetTime.Text = "设定时间：";
            // 
            // labelSystemTime
            // 
            this.labelSystemTime.AutoSize = true;
            this.labelSystemTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSystemTime.Location = new System.Drawing.Point(18, 32);
            this.labelSystemTime.Name = "labelSystemTime";
            this.labelSystemTime.Size = new System.Drawing.Size(117, 28);
            this.labelSystemTime.TabIndex = 0;
            this.labelSystemTime.Text = "系统时间：";
            // 
            // groupBoxRecord
            // 
            this.groupBoxRecord.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBoxRecord.Controls.Add(this.richTextBoxRecord);
            this.groupBoxRecord.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxRecord.Location = new System.Drawing.Point(3, 3);
            this.groupBoxRecord.Name = "groupBoxRecord";
            this.groupBoxRecord.Size = new System.Drawing.Size(580, 612);
            this.groupBoxRecord.TabIndex = 0;
            this.groupBoxRecord.TabStop = false;
            this.groupBoxRecord.Text = "会议记录";
            // 
            // richTextBoxRecord
            // 
            this.richTextBoxRecord.Font = new System.Drawing.Font("宋体", 21.75F);
            this.richTextBoxRecord.Location = new System.Drawing.Point(4, 32);
            this.richTextBoxRecord.Name = "richTextBoxRecord";
            this.richTextBoxRecord.Size = new System.Drawing.Size(568, 572);
            this.richTextBoxRecord.TabIndex = 0;
            this.richTextBoxRecord.Text = "";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "模拟联合国主席团工具";
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

