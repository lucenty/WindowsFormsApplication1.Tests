namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.chbRemoveAfter = new System.Windows.Forms.CheckBox();
            this.numArchivePeriod = new System.Windows.Forms.NumericUpDown();
            this.lblYears = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numArchivePeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // chbRemoveAfter
            // 
            this.chbRemoveAfter.AutoSize = true;
            this.chbRemoveAfter.Location = new System.Drawing.Point(12, 12);
            this.chbRemoveAfter.Name = "chbRemoveAfter";
            this.chbRemoveAfter.Size = new System.Drawing.Size(119, 17);
            this.chbRemoveAfter.TabIndex = 0;
            this.chbRemoveAfter.Text = "Usuń dokument po:";
            this.chbRemoveAfter.UseVisualStyleBackColor = true;
            // 
            // numArchivePeriod
            // 
            this.numArchivePeriod.Location = new System.Drawing.Point(12, 35);
            this.numArchivePeriod.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numArchivePeriod.Name = "numArchivePeriod";
            this.numArchivePeriod.Size = new System.Drawing.Size(93, 20);
            this.numArchivePeriod.TabIndex = 1;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(112, 41);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(36, 13);
            this.lblYears.TabIndex = 2;
            this.lblYears.Text = "latach";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(205, 75);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(124, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 110);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.numArchivePeriod);
            this.Controls.Add(this.chbRemoveAfter);
            this.Name = "Form1";
            this.Text = "Archiwizacja dokumentu";
            ((System.ComponentModel.ISupportInitialize)(this.numArchivePeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbRemoveAfter;
        private System.Windows.Forms.NumericUpDown numArchivePeriod;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}

