namespace MultiplePaste
{
    partial class CoPoly
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
            this.FilePath = new System.Windows.Forms.ListBox();
            this.Paste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilePath
            // 
            this.FilePath.FormattingEnabled = true;
            this.FilePath.Location = new System.Drawing.Point(0, 47);
            this.FilePath.Name = "FilePath";
            this.FilePath.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.FilePath.Size = new System.Drawing.Size(290, 108);
            this.FilePath.TabIndex = 0;
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(97, 186);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(75, 23);
            this.Paste.TabIndex = 1;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // CoPoly
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.FilePath);
            this.Name = "CoPoly";
            this.Text = "CoPoly";
            this.Load += new System.EventHandler(this.CoPoly_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FilePath;
        private System.Windows.Forms.Button Paste;
    }
}

