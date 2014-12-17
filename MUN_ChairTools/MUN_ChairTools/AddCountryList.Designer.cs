namespace MUN_ChairTools
{
    partial class AddCountryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCountryList));
            this.panelTotalCountry = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelTotalCountry
            // 
            resources.ApplyResources(this.panelTotalCountry, "panelTotalCountry");
            this.panelTotalCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalCountry.Name = "panelTotalCountry";
            // 
            // buttonBack
            // 
            resources.ApplyResources(this.buttonBack, "buttonBack");
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonConfirm
            // 
            resources.ApplyResources(this.buttonConfirm, "buttonConfirm");
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // AddCountryList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panelTotalCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddCountryList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotalCountry;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonConfirm;
    }
}