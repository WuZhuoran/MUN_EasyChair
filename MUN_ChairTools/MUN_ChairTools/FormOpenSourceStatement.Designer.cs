namespace MUN_ChairTools
{
    partial class FormOpenSourceStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpenSourceStatement));
            this.pictureBoxOpenSourceStatement = new System.Windows.Forms.PictureBox();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenSourceStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOpenSourceStatement
            // 
            this.pictureBoxOpenSourceStatement.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpenSourceStatement.Image")));
            this.pictureBoxOpenSourceStatement.Location = new System.Drawing.Point(17, 12);
            this.pictureBoxOpenSourceStatement.Name = "pictureBoxOpenSourceStatement";
            this.pictureBoxOpenSourceStatement.Size = new System.Drawing.Size(650, 530);
            this.pictureBoxOpenSourceStatement.TabIndex = 0;
            this.pictureBoxOpenSourceStatement.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(272, 552);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(135, 31);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormOpenSourceStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(684, 591);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.pictureBoxOpenSourceStatement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOpenSourceStatement";
            this.Text = "模拟联合国软件开源软件声明";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenSourceStatement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOpenSourceStatement;
        private System.Windows.Forms.Button buttonOK;

    }
}