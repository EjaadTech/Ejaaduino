namespace Updater_demo_wybuild
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
            this.automaticUpdater1 = new wyDay.Controls.AutomaticUpdater();
            this.checkForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.checkForUpdatesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdater1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // automaticUpdater1
            // 
            this.automaticUpdater1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.automaticUpdater1.ContainerForm = this;
            this.automaticUpdater1.GUID = "a7f8053f-e9f7-4118-9af8-6726913157ae";
            this.automaticUpdater1.Location = new System.Drawing.Point(256, 27);
            this.automaticUpdater1.Name = "automaticUpdater1";
            this.automaticUpdater1.Size = new System.Drawing.Size(16, 16);
            this.automaticUpdater1.TabIndex = 0;
            this.automaticUpdater1.ToolStripItem = this.checkForUpdates;
            this.automaticUpdater1.wyUpdateCommandline = null;
            this.automaticUpdater1.ClosingAborted += new System.EventHandler(this.automaticUpdater1_ClosingAborted);
            this.automaticUpdater1.Click += new System.EventHandler(this.automaticUpdater1_Click);
            // 
            // checkForUpdates
            // 
            this.checkForUpdates.Name = "checkForUpdates";
            this.checkForUpdates.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdates.Text = "Check for Updates";
            this.checkForUpdates.Click += new System.EventHandler(this.automaticUpdater1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // checkForUpdatesMenu
            // 
            this.checkForUpdatesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdates});
            this.checkForUpdatesMenu.Name = "checkForUpdatesMenu";
            this.checkForUpdatesMenu.Size = new System.Drawing.Size(61, 20);
            this.checkForUpdatesMenu.Text = "Options";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = ":) 2.12";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "YAY!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.automaticUpdater1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "UPDATED_V_1_FORM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdater1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private wyDay.Controls.AutomaticUpdater automaticUpdater1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesMenu;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdates;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;

    }
}

