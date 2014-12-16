namespace MUN_ChairTools
{
    partial class RollCallForm
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
            this.panelMainRollCall = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCheakedPresent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelMainRollCall
            // 
            this.panelMainRollCall.Location = new System.Drawing.Point(12, 12);
            this.panelMainRollCall.Name = "panelMainRollCall";
            this.panelMainRollCall.Size = new System.Drawing.Size(711, 358);
            this.panelMainRollCall.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 376);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(93, 36);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "后退";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(630, 376);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(93, 36);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "确定";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCheakedPresent
            // 
            this.buttonCheakedPresent.Location = new System.Drawing.Point(531, 376);
            this.buttonCheakedPresent.Name = "buttonCheakedPresent";
            this.buttonCheakedPresent.Size = new System.Drawing.Size(93, 36);
            this.buttonCheakedPresent.TabIndex = 3;
            this.buttonCheakedPresent.Text = "检查已到";
            this.buttonCheakedPresent.UseVisualStyleBackColor = true;
            this.buttonCheakedPresent.Click += new System.EventHandler(this.buttonCheakedPresent_Click);
            // 
            // RollCallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 424);
            this.Controls.Add(this.buttonCheakedPresent);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panelMainRollCall);
            this.Name = "RollCallForm";
            this.Text = "点名";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainRollCall;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCheakedPresent;
    }
}