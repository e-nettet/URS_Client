namespace URS_Client
{
    partial class UserControlPrismodel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrismodel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelJNummer = new System.Windows.Forms.Label();
            this.checkBoxSkiftPrismodel = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNyPrismodel = new System.Windows.Forms.ComboBox();
            this.textBoxSystemleverandoerNummer = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelPrismodel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelJNummer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxSkiftPrismodel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSystemleverandoerNummer, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxNyPrismodel, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 143);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelPrismodel
            // 
            this.labelPrismodel.AutoSize = true;
            this.labelPrismodel.Location = new System.Drawing.Point(169, 25);
            this.labelPrismodel.Name = "labelPrismodel";
            this.labelPrismodel.Size = new System.Drawing.Size(49, 13);
            this.labelPrismodel.TabIndex = 2;
            this.labelPrismodel.Text = "Ej hentet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prismodel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "J-nummer";
            // 
            // labelJNummer
            // 
            this.labelJNummer.AutoSize = true;
            this.labelJNummer.Location = new System.Drawing.Point(169, 0);
            this.labelJNummer.Name = "labelJNummer";
            this.labelJNummer.Size = new System.Drawing.Size(49, 13);
            this.labelJNummer.TabIndex = 4;
            this.labelJNummer.Text = "Ej hentet";
            // 
            // checkBoxSkiftPrismodel
            // 
            this.checkBoxSkiftPrismodel.AutoSize = true;
            this.checkBoxSkiftPrismodel.Location = new System.Drawing.Point(3, 53);
            this.checkBoxSkiftPrismodel.Name = "checkBoxSkiftPrismodel";
            this.checkBoxSkiftPrismodel.Size = new System.Drawing.Size(94, 17);
            this.checkBoxSkiftPrismodel.TabIndex = 1;
            this.checkBoxSkiftPrismodel.Text = "Skift prismodel";
            this.checkBoxSkiftPrismodel.UseVisualStyleBackColor = true;
            this.checkBoxSkiftPrismodel.CheckedChanged += new System.EventHandler(this.checkBoxSkiftPrismodel_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Systemleverandørnummer";
            // 
            // comboBoxNyPrismodel
            // 
            this.comboBoxNyPrismodel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNyPrismodel.FormattingEnabled = true;
            this.comboBoxNyPrismodel.Location = new System.Drawing.Point(169, 53);
            this.comboBoxNyPrismodel.Name = "comboBoxNyPrismodel";
            this.comboBoxNyPrismodel.Size = new System.Drawing.Size(161, 21);
            this.comboBoxNyPrismodel.TabIndex = 7;
            // 
            // textBoxSystemleverandoerNummer
            // 
            this.textBoxSystemleverandoerNummer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSystemleverandoerNummer.Location = new System.Drawing.Point(169, 78);
            this.textBoxSystemleverandoerNummer.Name = "textBoxSystemleverandoerNummer";
            this.textBoxSystemleverandoerNummer.Size = new System.Drawing.Size(161, 20);
            this.textBoxSystemleverandoerNummer.TabIndex = 8;
            // 
            // UserControlPrismodel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControlPrismodel";
            this.Size = new System.Drawing.Size(340, 150);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSkiftPrismodel;
        private System.Windows.Forms.Label labelPrismodel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelJNummer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNyPrismodel;
        private System.Windows.Forms.TextBox textBoxSystemleverandoerNummer;
    }
}
