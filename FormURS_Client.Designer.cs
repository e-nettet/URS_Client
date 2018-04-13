namespace URS_Client
{
    partial class FormIndsend
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonTilbage = new System.Windows.Forms.Button();
            this.backgroundWorkerValidateParty = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSendUdbudshaendelse = new System.ComponentModel.BackgroundWorker();
            this.wizardTabcontrol1 = new URS_Client.WizardTabcontrol();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.userControlLogon1 = new URS_Client.UserControlLogon();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userControlUdbud1 = new URS_Client.UserControlUdbud();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.wizardTabcontrol1.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 283);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(602, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel1.Text = "OK";
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(519, 259);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "&Næste";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonTilbage
            // 
            this.buttonTilbage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTilbage.Location = new System.Drawing.Point(439, 259);
            this.buttonTilbage.Name = "buttonTilbage";
            this.buttonTilbage.Size = new System.Drawing.Size(75, 23);
            this.buttonTilbage.TabIndex = 0;
            this.buttonTilbage.Text = "&Tilbage";
            this.buttonTilbage.UseVisualStyleBackColor = true;
            this.buttonTilbage.Click += new System.EventHandler(this.ButtonTilbage_Click);
            // 
            // backgroundWorkerValidateParty
            // 
            this.backgroundWorkerValidateParty.WorkerReportsProgress = true;
            this.backgroundWorkerValidateParty.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerValidateParty_DoWork);
            this.backgroundWorkerValidateParty.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.backgroundWorkerValidateParty.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // backgroundWorkerSendUdbudshaendelse
            // 
            this.backgroundWorkerSendUdbudshaendelse.WorkerReportsProgress = true;
            this.backgroundWorkerSendUdbudshaendelse.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSendUdbudshaendelse_DoWork);
            this.backgroundWorkerSendUdbudshaendelse.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.backgroundWorkerSendUdbudshaendelse.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // wizardTabcontrol1
            // 
            this.wizardTabcontrol1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardTabcontrol1.Controls.Add(this.tabPageLogin);
            this.wizardTabcontrol1.Controls.Add(this.tabPage1);
            this.wizardTabcontrol1.Controls.Add(this.tabPage2);
            this.wizardTabcontrol1.Location = new System.Drawing.Point(15, 12);
            this.wizardTabcontrol1.Name = "wizardTabcontrol1";
            this.wizardTabcontrol1.SelectedIndex = 0;
            this.wizardTabcontrol1.Size = new System.Drawing.Size(578, 239);
            this.wizardTabcontrol1.TabIndex = 1;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.userControlLogon1);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(570, 213);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // userControlLogon1
            // 
            this.userControlLogon1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlLogon1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlLogon1.Jnummer = null;
            this.userControlLogon1.Location = new System.Drawing.Point(5, 6);
            this.userControlLogon1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlLogon1.Miljoe = URS_Client.Miljoe.Test;
            this.userControlLogon1.Name = "userControlLogon1";
            this.userControlLogon1.PartID = null;
            this.userControlLogon1.Password = null;
            this.userControlLogon1.Size = new System.Drawing.Size(561, 202);
            this.userControlLogon1.SystemleverandoerID = 0;
            this.userControlLogon1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userControlUdbud1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 213);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userControlUdbud1
            // 
            this.userControlUdbud1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlUdbud1.AutoSize = true;
            this.userControlUdbud1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlUdbud1.Location = new System.Drawing.Point(5, 5);
            this.userControlUdbud1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlUdbud1.Name = "userControlUdbud1";
            this.userControlUdbud1.Size = new System.Drawing.Size(560, 203);
            this.userControlUdbud1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 213);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormIndsend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 305);
            this.Controls.Add(this.buttonTilbage);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.wizardTabcontrol1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormIndsend";
            this.Text = "URS Client";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.wizardTabcontrol1.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonTilbage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerValidateParty;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSendUdbudshaendelse;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageLogin;
        private UserControlLogon userControlLogon1;
        private WizardTabcontrol wizardTabcontrol1;
        private UserControlUdbud userControlUdbud1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

