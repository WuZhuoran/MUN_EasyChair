namespace MUN_ChairTools
{
    partial class MotionMCMain
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
            this.components = new System.ComponentModel.Container();
            this.listBoxTest = new System.Windows.Forms.ListBox();
            this.progressBarPerTime = new System.Windows.Forms.ProgressBar();
            this.labelMCTopic = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBoxAddCountry = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinus = new System.Windows.Forms.PictureBox();
            this.comboBoxAddCountry = new System.Windows.Forms.ComboBox();
            this.buttonEndMotion = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerPerTime = new System.Windows.Forms.Timer(this.components);
            this.labelPerTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinus)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxTest
            // 
            this.listBoxTest.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.listBoxTest.FormattingEnabled = true;
            this.listBoxTest.HorizontalScrollbar = true;
            this.listBoxTest.ItemHeight = 28;
            this.listBoxTest.Location = new System.Drawing.Point(30, 127);
            this.listBoxTest.Name = "listBoxTest";
            this.listBoxTest.Size = new System.Drawing.Size(176, 228);
            this.listBoxTest.TabIndex = 0;
            // 
            // progressBarPerTime
            // 
            this.progressBarPerTime.Location = new System.Drawing.Point(30, 372);
            this.progressBarPerTime.Name = "progressBarPerTime";
            this.progressBarPerTime.Size = new System.Drawing.Size(176, 23);
            this.progressBarPerTime.TabIndex = 1;
            // 
            // labelMCTopic
            // 
            this.labelMCTopic.AutoSize = true;
            this.labelMCTopic.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelMCTopic.Location = new System.Drawing.Point(25, 21);
            this.labelMCTopic.Name = "labelMCTopic";
            this.labelMCTopic.Size = new System.Drawing.Size(75, 28);
            this.labelMCTopic.TabIndex = 2;
            this.labelMCTopic.Text = "议题：";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTime.Location = new System.Drawing.Point(25, 71);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(75, 28);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "总时长";
            // 
            // pictureBoxAddCountry
            // 
            this.pictureBoxAddCountry.Image = global::MUN_ChairTools.Properties.Resources.plus;
            this.pictureBoxAddCountry.InitialImage = global::MUN_ChairTools.Properties.Resources.plus;
            this.pictureBoxAddCountry.Location = new System.Drawing.Point(212, 169);
            this.pictureBoxAddCountry.Name = "pictureBoxAddCountry";
            this.pictureBoxAddCountry.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxAddCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAddCountry.TabIndex = 4;
            this.pictureBoxAddCountry.TabStop = false;
            this.pictureBoxAddCountry.Click += new System.EventHandler(this.pictureBoxAddCountry_Click);
            // 
            // pictureBoxMinus
            // 
            this.pictureBoxMinus.Image = global::MUN_ChairTools.Properties.Resources.minus;
            this.pictureBoxMinus.InitialImage = global::MUN_ChairTools.Properties.Resources.minus;
            this.pictureBoxMinus.Location = new System.Drawing.Point(337, 169);
            this.pictureBoxMinus.Name = "pictureBoxMinus";
            this.pictureBoxMinus.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMinus.TabIndex = 5;
            this.pictureBoxMinus.TabStop = false;
            this.pictureBoxMinus.Click += new System.EventHandler(this.pictureBoxMinus_Click);
            // 
            // comboBoxAddCountry
            // 
            this.comboBoxAddCountry.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxAddCountry.FormattingEnabled = true;
            this.comboBoxAddCountry.Location = new System.Drawing.Point(212, 127);
            this.comboBoxAddCountry.Name = "comboBoxAddCountry";
            this.comboBoxAddCountry.Size = new System.Drawing.Size(175, 36);
            this.comboBoxAddCountry.TabIndex = 6;
            // 
            // buttonEndMotion
            // 
            this.buttonEndMotion.Location = new System.Drawing.Point(450, 412);
            this.buttonEndMotion.Name = "buttonEndMotion";
            this.buttonEndMotion.Size = new System.Drawing.Size(100, 37);
            this.buttonEndMotion.TabIndex = 7;
            this.buttonEndMotion.Text = "结束动议";
            this.buttonEndMotion.UseVisualStyleBackColor = true;
            this.buttonEndMotion.Click += new System.EventHandler(this.buttonEndMotion_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(30, 412);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(100, 37);
            this.buttonPause.TabIndex = 8;
            this.buttonPause.Text = "暂停";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(136, 412);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 37);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "开始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerPerTime
            // 
            this.timerPerTime.Interval = 1000;
            this.timerPerTime.Tick += new System.EventHandler(this.timerPerTime_Tick);
            // 
            // labelPerTime
            // 
            this.labelPerTime.AutoSize = true;
            this.labelPerTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelPerTime.Location = new System.Drawing.Point(222, 367);
            this.labelPerTime.Name = "labelPerTime";
            this.labelPerTime.Size = new System.Drawing.Size(85, 28);
            this.labelPerTime.TabIndex = 10;
            this.labelPerTime.Text = "00：00";
            // 
            // MotionMCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 461);
            this.Controls.Add(this.labelPerTime);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonEndMotion);
            this.Controls.Add(this.comboBoxAddCountry);
            this.Controls.Add(this.pictureBoxMinus);
            this.Controls.Add(this.pictureBoxAddCountry);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelMCTopic);
            this.Controls.Add(this.progressBarPerTime);
            this.Controls.Add(this.listBoxTest);
            this.Name = "MotionMCMain";
            this.Text = "有主持核心磋商";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTest;
        private System.Windows.Forms.ProgressBar progressBarPerTime;
        private System.Windows.Forms.Label labelMCTopic;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pictureBoxAddCountry;
        private System.Windows.Forms.PictureBox pictureBoxMinus;
        private System.Windows.Forms.ComboBox comboBoxAddCountry;
        private System.Windows.Forms.Button buttonEndMotion;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerPerTime;
        private System.Windows.Forms.Label labelPerTime;
    }
}