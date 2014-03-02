namespace UpdateMe
{
    partial class UpdateMe
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
            this.update_bttn = new System.Windows.Forms.Button();
            this.checkForUpdate_bttn = new System.Windows.Forms.Button();
            this.updateResult = new System.Windows.Forms.Label();
            this.downloadsurl = new System.Windows.Forms.Label();
            this.versionfilename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // update_bttn
            // 
            this.update_bttn.Location = new System.Drawing.Point(67, 136);
            this.update_bttn.Name = "update_bttn";
            this.update_bttn.Size = new System.Drawing.Size(120, 73);
            this.update_bttn.TabIndex = 6;
            this.update_bttn.Text = "Update ME!";
            this.update_bttn.Visible = false;
            this.update_bttn.Click += new System.EventHandler(this.update_bttn_Click);
            // 
            // checkForUpdate_bttn
            // 
            this.checkForUpdate_bttn.Location = new System.Drawing.Point(67, 69);
            this.checkForUpdate_bttn.Name = "checkForUpdate_bttn";
            this.checkForUpdate_bttn.Size = new System.Drawing.Size(120, 23);
            this.checkForUpdate_bttn.TabIndex = 1;
            this.checkForUpdate_bttn.Text = "Check for update";
            this.checkForUpdate_bttn.UseVisualStyleBackColor = true;
            this.checkForUpdate_bttn.Click += new System.EventHandler(this.checkForUpdate_bttn_Click);
            // 
            // updateResult
            // 
            this.updateResult.AutoSize = true;
            this.updateResult.Location = new System.Drawing.Point(96, 106);
            this.updateResult.Name = "updateResult";
            this.updateResult.Size = new System.Drawing.Size(37, 13);
            this.updateResult.TabIndex = 2;
            this.updateResult.Text = "Status";
            // 
            // downloadsurl
            // 
            this.downloadsurl.AutoSize = true;
            this.downloadsurl.Location = new System.Drawing.Point(64, 23);
            this.downloadsurl.Name = "downloadsurl";
            this.downloadsurl.Size = new System.Drawing.Size(118, 13);
            this.downloadsurl.TabIndex = 3;
            this.downloadsurl.Text = "http://nasirjumani.com/";
            // 
            // versionfilename
            // 
            this.versionfilename.AutoSize = true;
            this.versionfilename.Location = new System.Drawing.Point(107, 48);
            this.versionfilename.Name = "versionfilename";
            this.versionfilename.Size = new System.Drawing.Size(34, 13);
            this.versionfilename.TabIndex = 4;
            this.versionfilename.Text = "1.001";
            // 
            // UpdateMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 316);
            this.Controls.Add(this.versionfilename);
            this.Controls.Add(this.downloadsurl);
            this.Controls.Add(this.updateResult);
            this.Controls.Add(this.checkForUpdate_bttn);
            this.Controls.Add(this.update_bttn);
            this.Name = "UpdateMe";
            this.Text = "UpdateMe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_bttn;
        private System.Windows.Forms.Button checkForUpdate_bttn;
        private System.Windows.Forms.Label updateResult;
        private System.Windows.Forms.Label downloadsurl;
        private System.Windows.Forms.Label versionfilename;
    }
}

