namespace MUN_ChairTools
{
    partial class ChooseConference
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.listBoxConference = new System.Windows.Forms.ListBox();
            this.listBoxCommittee = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 311);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(72, 34);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(378, 311);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(72, 34);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "确定";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // listBoxConference
            // 
            this.listBoxConference.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.listBoxConference.FormattingEnabled = true;
            this.listBoxConference.ItemHeight = 28;
            this.listBoxConference.Location = new System.Drawing.Point(12, 12);
            this.listBoxConference.Name = "listBoxConference";
            this.listBoxConference.Size = new System.Drawing.Size(202, 256);
            this.listBoxConference.TabIndex = 2;
            // 
            // listBoxCommittee
            // 
            this.listBoxCommittee.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.listBoxCommittee.FormattingEnabled = true;
            this.listBoxCommittee.ItemHeight = 28;
            this.listBoxCommittee.Location = new System.Drawing.Point(248, 12);
            this.listBoxCommittee.Name = "listBoxCommittee";
            this.listBoxCommittee.Size = new System.Drawing.Size(202, 256);
            this.listBoxCommittee.TabIndex = 3;
            // 
            // ChooseConference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 357);
            this.ControlBox = false;
            this.Controls.Add(this.listBoxCommittee);
            this.Controls.Add(this.listBoxConference);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseConference";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.ListBox listBoxConference;
        private System.Windows.Forms.ListBox listBoxCommittee;
    }
}