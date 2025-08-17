namespace NBTExplorer.Windows
{
    partial class HexEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._buttonOK = new System.Windows.Forms.Button();
            this._buttonImport = new System.Windows.Forms.Button();
            this._buttonExport = new System.Windows.Forms.Button();
            this.viewTabs = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(798, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.Location = new System.Drawing.Point(546, 472);
            this._buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(112, 35);
            this._buttonCancel.TabIndex = 13;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            // 
            // _buttonOK
            // 
            this._buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonOK.Location = new System.Drawing.Point(668, 472);
            this._buttonOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._buttonOK.Name = "_buttonOK";
            this._buttonOK.Size = new System.Drawing.Size(112, 35);
            this._buttonOK.TabIndex = 12;
            this._buttonOK.Text = "OK";
            this._buttonOK.UseVisualStyleBackColor = true;
            this._buttonOK.Click += new System.EventHandler(this._buttonOK_Click);
            // 
            // _buttonImport
            // 
            this._buttonImport.Location = new System.Drawing.Point(18, 472);
            this._buttonImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._buttonImport.Name = "_buttonImport";
            this._buttonImport.Size = new System.Drawing.Size(112, 35);
            this._buttonImport.TabIndex = 14;
            this._buttonImport.Text = "Import";
            this._buttonImport.UseVisualStyleBackColor = true;
            this._buttonImport.Click += new System.EventHandler(this._buttonImport_Click);
            // 
            // _buttonExport
            // 
            this._buttonExport.Location = new System.Drawing.Point(140, 472);
            this._buttonExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._buttonExport.Name = "_buttonExport";
            this._buttonExport.Size = new System.Drawing.Size(112, 35);
            this._buttonExport.TabIndex = 15;
            this._buttonExport.Text = "Export";
            this._buttonExport.UseVisualStyleBackColor = true;
            this._buttonExport.Click += new System.EventHandler(this._buttonExport_Click);
            // 
            // viewTabs
            // 
            this.viewTabs.Location = new System.Drawing.Point(18, 18);
            this.viewTabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewTabs.Name = "viewTabs";
            this.viewTabs.SelectedIndex = 0;
            this.viewTabs.Size = new System.Drawing.Size(762, 445);
            this.viewTabs.TabIndex = 16;
            // 
            // HexEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._buttonCancel;
            this.ClientSize = new System.Drawing.Size(798, 546);
            this.Controls.Add(this.viewTabs);
            this.Controls.Add(this._buttonExport);
            this.Controls.Add(this._buttonImport);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonOK);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HexEditor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HexEditor";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.Button _buttonOK;
        private System.Windows.Forms.Button _buttonImport;
        private System.Windows.Forms.Button _buttonExport;
        private System.Windows.Forms.TabControl viewTabs;
    }
}