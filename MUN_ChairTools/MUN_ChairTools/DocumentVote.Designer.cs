namespace MUN_ChairTools
{
    partial class DocumentVote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentVote));
            this.labelVoteYes = new System.Windows.Forms.Label();
            this.labelVoteNo = new System.Windows.Forms.Label();
            this.labelVoteAbsense = new System.Windows.Forms.Label();
            this.labelVotePass = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.panelAllCountries = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.groupBoxVote = new System.Windows.Forms.GroupBox();
            this.pictureBoxVotePass = new System.Windows.Forms.PictureBox();
            this.pictureBoxVoteAbsence = new System.Windows.Forms.PictureBox();
            this.pictureBoxVoteNo = new System.Windows.Forms.PictureBox();
            this.pictureBoxVoteYes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVotePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoteAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoteNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoteYes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVoteYes
            // 
            resources.ApplyResources(this.labelVoteYes, "labelVoteYes");
            this.labelVoteYes.Name = "labelVoteYes";
            // 
            // labelVoteNo
            // 
            resources.ApplyResources(this.labelVoteNo, "labelVoteNo");
            this.labelVoteNo.Name = "labelVoteNo";
            // 
            // labelVoteAbsense
            // 
            resources.ApplyResources(this.labelVoteAbsense, "labelVoteAbsense");
            this.labelVoteAbsense.Name = "labelVoteAbsense";
            // 
            // labelVotePass
            // 
            resources.ApplyResources(this.labelVotePass, "labelVotePass");
            this.labelVotePass.Name = "labelVotePass";
            // 
            // labelFileName
            // 
            resources.ApplyResources(this.labelFileName, "labelFileName");
            this.labelFileName.Name = "labelFileName";
            // 
            // textBoxFileName
            // 
            resources.ApplyResources(this.textBoxFileName, "textBoxFileName");
            this.textBoxFileName.Name = "textBoxFileName";
            // 
            // panelAllCountries
            // 
            resources.ApplyResources(this.panelAllCountries, "panelAllCountries");
            this.panelAllCountries.BackColor = System.Drawing.SystemColors.Control;
            this.panelAllCountries.Name = "panelAllCountries";
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonClear
            // 
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            resources.ApplyResources(this.buttonConfirm, "buttonConfirm");
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // groupBoxInformation
            // 
            resources.ApplyResources(this.groupBoxInformation, "groupBoxInformation");
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.TabStop = false;
            // 
            // groupBoxVote
            // 
            resources.ApplyResources(this.groupBoxVote, "groupBoxVote");
            this.groupBoxVote.Name = "groupBoxVote";
            this.groupBoxVote.TabStop = false;
            // 
            // pictureBoxVotePass
            // 
            this.pictureBoxVotePass.Image = global::MUN_ChairTools.Properties.Resources.Pass;
            resources.ApplyResources(this.pictureBoxVotePass, "pictureBoxVotePass");
            this.pictureBoxVotePass.Name = "pictureBoxVotePass";
            this.pictureBoxVotePass.TabStop = false;
            this.pictureBoxVotePass.Click += new System.EventHandler(this.pictureBoxVotePass_Click);
            // 
            // pictureBoxVoteAbsence
            // 
            this.pictureBoxVoteAbsence.Image = global::MUN_ChairTools.Properties.Resources.Absense;
            resources.ApplyResources(this.pictureBoxVoteAbsence, "pictureBoxVoteAbsence");
            this.pictureBoxVoteAbsence.Name = "pictureBoxVoteAbsence";
            this.pictureBoxVoteAbsence.TabStop = false;
            this.pictureBoxVoteAbsence.Click += new System.EventHandler(this.pictureBoxVoteAbsence_Click);
            // 
            // pictureBoxVoteNo
            // 
            this.pictureBoxVoteNo.Image = global::MUN_ChairTools.Properties.Resources.No;
            resources.ApplyResources(this.pictureBoxVoteNo, "pictureBoxVoteNo");
            this.pictureBoxVoteNo.Name = "pictureBoxVoteNo";
            this.pictureBoxVoteNo.TabStop = false;
            this.pictureBoxVoteNo.Click += new System.EventHandler(this.pictureBoxVoteNo_Click);
            // 
            // pictureBoxVoteYes
            // 
            this.pictureBoxVoteYes.Image = global::MUN_ChairTools.Properties.Resources.Yes;
            resources.ApplyResources(this.pictureBoxVoteYes, "pictureBoxVoteYes");
            this.pictureBoxVoteYes.Name = "pictureBoxVoteYes";
            this.pictureBoxVoteYes.TabStop = false;
            this.pictureBoxVoteYes.Click += new System.EventHandler(this.pictureBoxVoteYes_Click);
            // 
            // DocumentVote
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxVote);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panelAllCountries);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.labelVotePass);
            this.Controls.Add(this.labelVoteAbsense);
            this.Controls.Add(this.labelVoteNo);
            this.Controls.Add(this.labelVoteYes);
            this.Controls.Add(this.pictureBoxVotePass);
            this.Controls.Add(this.pictureBoxVoteAbsence);
            this.Controls.Add(this.pictureBoxVoteNo);
            this.Controls.Add(this.pictureBoxVoteYes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocumentVote";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVotePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoteAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoteNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoteYes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVoteYes;
        private System.Windows.Forms.PictureBox pictureBoxVoteNo;
        private System.Windows.Forms.PictureBox pictureBoxVoteAbsence;
        private System.Windows.Forms.PictureBox pictureBoxVotePass;
        private System.Windows.Forms.Label labelVoteYes;
        private System.Windows.Forms.Label labelVoteNo;
        private System.Windows.Forms.Label labelVoteAbsense;
        private System.Windows.Forms.Label labelVotePass;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Panel panelAllCountries;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.GroupBox groupBoxVote;
    }
}