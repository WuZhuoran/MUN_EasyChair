namespace MUN_ChairTools
{
    partial class MotionMC
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
            this.labelMotionCountry = new System.Windows.Forms.Label();
            this.comboBoxMotionCountry = new System.Windows.Forms.ComboBox();
            this.labelMotionTopic = new System.Windows.Forms.Label();
            this.textBoxMotionTopic = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.labelPerTime = new System.Windows.Forms.Label();
            this.numericUpDownTotalTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPerTime = new System.Windows.Forms.NumericUpDown();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelSecond2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPerTime)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMotionCountry
            // 
            this.labelMotionCountry.AutoSize = true;
            this.labelMotionCountry.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelMotionCountry.Location = new System.Drawing.Point(12, 24);
            this.labelMotionCountry.Name = "labelMotionCountry";
            this.labelMotionCountry.Size = new System.Drawing.Size(96, 28);
            this.labelMotionCountry.TabIndex = 3;
            this.labelMotionCountry.Text = "动议国：";
            // 
            // comboBoxMotionCountry
            // 
            this.comboBoxMotionCountry.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxMotionCountry.FormattingEnabled = true;
            this.comboBoxMotionCountry.Location = new System.Drawing.Point(114, 21);
            this.comboBoxMotionCountry.Name = "comboBoxMotionCountry";
            this.comboBoxMotionCountry.Size = new System.Drawing.Size(240, 36);
            this.comboBoxMotionCountry.TabIndex = 2;
            // 
            // labelMotionTopic
            // 
            this.labelMotionTopic.AutoSize = true;
            this.labelMotionTopic.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelMotionTopic.Location = new System.Drawing.Point(33, 78);
            this.labelMotionTopic.Name = "labelMotionTopic";
            this.labelMotionTopic.Size = new System.Drawing.Size(75, 28);
            this.labelMotionTopic.TabIndex = 4;
            this.labelMotionTopic.Text = "议题：";
            // 
            // textBoxMotionTopic
            // 
            this.textBoxMotionTopic.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBoxMotionTopic.Location = new System.Drawing.Point(114, 75);
            this.textBoxMotionTopic.Multiline = true;
            this.textBoxMotionTopic.Name = "textBoxMotionTopic";
            this.textBoxMotionTopic.Size = new System.Drawing.Size(240, 92);
            this.textBoxMotionTopic.TabIndex = 5;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(269, 275);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(85, 45);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "确定";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 275);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 45);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTotalTime.Location = new System.Drawing.Point(12, 175);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(96, 28);
            this.labelTotalTime.TabIndex = 8;
            this.labelTotalTime.Text = "总时长：";
            // 
            // labelPerTime
            // 
            this.labelPerTime.AutoSize = true;
            this.labelPerTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelPerTime.Location = new System.Drawing.Point(12, 214);
            this.labelPerTime.Name = "labelPerTime";
            this.labelPerTime.Size = new System.Drawing.Size(159, 28);
            this.labelPerTime.TabIndex = 9;
            this.labelPerTime.Text = "每位代表时长：";
            // 
            // numericUpDownTotalTime
            // 
            this.numericUpDownTotalTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDownTotalTime.Location = new System.Drawing.Point(114, 173);
            this.numericUpDownTotalTime.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownTotalTime.Name = "numericUpDownTotalTime";
            this.numericUpDownTotalTime.Size = new System.Drawing.Size(197, 35);
            this.numericUpDownTotalTime.TabIndex = 10;
            // 
            // numericUpDownPerTime
            // 
            this.numericUpDownPerTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDownPerTime.Location = new System.Drawing.Point(166, 212);
            this.numericUpDownPerTime.Name = "numericUpDownPerTime";
            this.numericUpDownPerTime.Size = new System.Drawing.Size(145, 35);
            this.numericUpDownPerTime.TabIndex = 11;
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelSecond.Location = new System.Drawing.Point(317, 175);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(33, 28);
            this.labelSecond.TabIndex = 12;
            this.labelSecond.Text = "秒";
            // 
            // labelSecond2
            // 
            this.labelSecond2.AutoSize = true;
            this.labelSecond2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelSecond2.Location = new System.Drawing.Point(317, 214);
            this.labelSecond2.Name = "labelSecond2";
            this.labelSecond2.Size = new System.Drawing.Size(33, 28);
            this.labelSecond2.TabIndex = 13;
            this.labelSecond2.Text = "秒";
            // 
            // MotionMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 332);
            this.ControlBox = false;
            this.Controls.Add(this.labelSecond2);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.numericUpDownPerTime);
            this.Controls.Add(this.numericUpDownTotalTime);
            this.Controls.Add(this.labelPerTime);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxMotionTopic);
            this.Controls.Add(this.labelMotionTopic);
            this.Controls.Add(this.labelMotionCountry);
            this.Controls.Add(this.comboBoxMotionCountry);
            this.MaximumSize = new System.Drawing.Size(382, 371);
            this.MinimumSize = new System.Drawing.Size(382, 371);
            this.Name = "MotionMC";
            this.Text = "有主持核心磋商";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPerTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMotionCountry;
        private System.Windows.Forms.ComboBox comboBoxMotionCountry;
        private System.Windows.Forms.Label labelMotionTopic;
        private System.Windows.Forms.TextBox textBoxMotionTopic;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Label labelPerTime;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalTime;
        private System.Windows.Forms.NumericUpDown numericUpDownPerTime;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelSecond2;
    }
}