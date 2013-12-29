namespace Ejaaduino
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
            this.btn_programmer = new System.Windows.Forms.Button();
            this.btn_usbSerial = new System.Windows.Forms.Button();
            this.btn_custom = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_arduino = new System.Windows.Forms.Button();
            this.lnk_EjaadTech = new System.Windows.Forms.LinkLabel();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_programmer
            // 
            this.btn_programmer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_programmer.FlatAppearance.BorderSize = 0;
            this.btn_programmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_programmer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_programmer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_programmer.Location = new System.Drawing.Point(105, 139);
            this.btn_programmer.Name = "btn_programmer";
            this.btn_programmer.Size = new System.Drawing.Size(133, 67);
            this.btn_programmer.TabIndex = 0;
            this.btn_programmer.Text = "Programmer Mode";
            this.btn_programmer.UseVisualStyleBackColor = false;
            this.btn_programmer.Click += new System.EventHandler(this.btn_programmer_Click);
            // 
            // btn_usbSerial
            // 
            this.btn_usbSerial.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_usbSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usbSerial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usbSerial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_usbSerial.Location = new System.Drawing.Point(244, 139);
            this.btn_usbSerial.Name = "btn_usbSerial";
            this.btn_usbSerial.Size = new System.Drawing.Size(133, 68);
            this.btn_usbSerial.TabIndex = 1;
            this.btn_usbSerial.Text = "USB <->Serial Mode";
            this.btn_usbSerial.UseVisualStyleBackColor = false;
            this.btn_usbSerial.Click += new System.EventHandler(this.btn_usbSerial_Click);
            // 
            // btn_custom
            // 
            this.btn_custom.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_custom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_custom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_custom.Location = new System.Drawing.Point(384, 139);
            this.btn_custom.Name = "btn_custom";
            this.btn_custom.Size = new System.Drawing.Size(133, 68);
            this.btn_custom.TabIndex = 2;
            this.btn_custom.Text = "Custom Firmware";
            this.btn_custom.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(628, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // btn_arduino
            // 
            this.btn_arduino.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_arduino.FlatAppearance.BorderSize = 0;
            this.btn_arduino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_arduino.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_arduino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_arduino.Location = new System.Drawing.Point(105, 83);
            this.btn_arduino.Name = "btn_arduino";
            this.btn_arduino.Size = new System.Drawing.Size(412, 50);
            this.btn_arduino.TabIndex = 4;
            this.btn_arduino.Text = "Open Arduino IDE";
            this.btn_arduino.UseVisualStyleBackColor = false;
            this.btn_arduino.Click += new System.EventHandler(this.btn_arduino_Click);
            // 
            // lnk_EjaadTech
            // 
            this.lnk_EjaadTech.AutoSize = true;
            this.lnk_EjaadTech.Location = new System.Drawing.Point(564, 318);
            this.lnk_EjaadTech.Name = "lnk_EjaadTech";
            this.lnk_EjaadTech.Size = new System.Drawing.Size(59, 13);
            this.lnk_EjaadTech.TabIndex = 6;
            this.lnk_EjaadTech.TabStop = true;
            this.lnk_EjaadTech.Text = "EjaadTech";
            this.lnk_EjaadTech.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_EjaadTech_LinkClicked);
            // 
            // lbl_heading
            // 
            this.lbl_heading.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(106, 32);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(411, 48);
            this.lbl_heading.TabIndex = 7;
            this.lbl_heading.Text = "Ejaaduino App V2.3";
            this.lbl_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Exit.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exit.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Exit.Location = new System.Drawing.Point(600, -4);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(28, 29);
            this.lbl_Exit.TabIndex = 8;
            this.lbl_Exit.Text = "x";
            this.lbl_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            this.lbl_Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Exit_MouseDown);
            this.lbl_Exit.MouseEnter += new System.EventHandler(this.lbl_Exit_MouseEnter);
            this.lbl_Exit.MouseLeave += new System.EventHandler(this.lbl_Exit_MouseLeave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 212);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(623, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(628, 335);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_Exit);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.lnk_EjaadTech);
            this.Controls.Add(this.btn_arduino);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_custom);
            this.Controls.Add(this.btn_usbSerial);
            this.Controls.Add(this.btn_programmer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ejaaduino App V2.3";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_programmer;
        private System.Windows.Forms.Button btn_usbSerial;
        private System.Windows.Forms.Button btn_custom;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_arduino;
        private System.Windows.Forms.LinkLabel lnk_EjaadTech;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

