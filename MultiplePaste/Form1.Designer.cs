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
            this.SuspendLayout();
            // 
            // FilePath
            // 
            this.FilePath.FormattingEnabled = true;
            this.FilePath.Location = new System.Drawing.Point(-2, 50);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(285, 95);
            this.FilePath.TabIndex = 0;
            // 
            // CoPoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.FilePath);
            this.Name = "CoPoly";
            this.Text = "CoPoly";
            this.Load += new System.EventHandler(this.CoPoly_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FilePath;
    }
}

