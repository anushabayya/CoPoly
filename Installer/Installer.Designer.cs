namespace Installer
{
    partial class Installer
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
            this.FOLDER_BASE_PATH_TEXT_BOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BROWSE_BUTTON = new System.Windows.Forms.Button();
            this.INSTALL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FOLDER_BASE_PATH_TEXT_BOX
            // 
            this.FOLDER_BASE_PATH_TEXT_BOX.Location = new System.Drawing.Point(76, 23);
            this.FOLDER_BASE_PATH_TEXT_BOX.Name = "FOLDER_BASE_PATH_TEXT_BOX";
            this.FOLDER_BASE_PATH_TEXT_BOX.Size = new System.Drawing.Size(200, 20);
            this.FOLDER_BASE_PATH_TEXT_BOX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder path";
            // 
            // BROWSE_BUTTON
            // 
            this.BROWSE_BUTTON.Location = new System.Drawing.Point(284, 22);
            this.BROWSE_BUTTON.Name = "BROWSE_BUTTON";
            this.BROWSE_BUTTON.Size = new System.Drawing.Size(29, 20);
            this.BROWSE_BUTTON.TabIndex = 2;
            this.BROWSE_BUTTON.Text = "...";
            this.BROWSE_BUTTON.UseVisualStyleBackColor = true;
            this.BROWSE_BUTTON.Click += new System.EventHandler(this.FileBrowse);
            // 
            // INSTALL
            // 
            this.INSTALL.Location = new System.Drawing.Point(222, 49);
            this.INSTALL.Name = "INSTALL";
            this.INSTALL.Size = new System.Drawing.Size(92, 27);
            this.INSTALL.TabIndex = 3;
            this.INSTALL.Text = "Install";
            this.INSTALL.UseVisualStyleBackColor = true;
            this.INSTALL.Click += new System.EventHandler(this.InstallMultiPaste);

            // 
            // Installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 88);
            this.Controls.Add(this.INSTALL);
            this.Controls.Add(this.BROWSE_BUTTON);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FOLDER_BASE_PATH_TEXT_BOX);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Installer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiPaste installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BROWSE_BUTTON;
        private System.Windows.Forms.Button INSTALL;
        private System.Windows.Forms.TextBox FOLDER_BASE_PATH_TEXT_BOX;
    }
}

