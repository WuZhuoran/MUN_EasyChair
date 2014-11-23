namespace MUN_ChairTools
{
    partial class SessionChooser
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelConferenceInfo = new System.Windows.Forms.Label();
            this.comboBoxSessionChooser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 196);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(99, 53);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "后退";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(273, 196);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(99, 53);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "确定";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelConferenceInfo
            // 
            this.labelConferenceInfo.AutoSize = true;
            this.labelConferenceInfo.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelConferenceInfo.Location = new System.Drawing.Point(12, 9);
            this.labelConferenceInfo.Name = "labelConferenceInfo";
            this.labelConferenceInfo.Size = new System.Drawing.Size(0, 26);
            this.labelConferenceInfo.TabIndex = 2;
            // 
            // comboBoxSessionChooser
            // 
            this.comboBoxSessionChooser.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxSessionChooser.FormattingEnabled = true;
            this.comboBoxSessionChooser.Location = new System.Drawing.Point(12, 129);
            this.comboBoxSessionChooser.Name = "comboBoxSessionChooser";
            this.comboBoxSessionChooser.Size = new System.Drawing.Size(360, 34);
            this.comboBoxSessionChooser.TabIndex = 3;
            // 
            // SessionChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.comboBoxSessionChooser);
            this.Controls.Add(this.labelConferenceInfo);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonBack);
            this.Name = "SessionChooser";
            this.Text = "SessionChooser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelConferenceInfo;
        private System.Windows.Forms.ComboBox comboBoxSessionChooser;
    }
}