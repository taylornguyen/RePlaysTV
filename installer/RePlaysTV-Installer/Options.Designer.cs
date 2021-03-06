﻿namespace RePlaysTV_Installer {
    partial class Options {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.playsSetupUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.cleanInstall = new System.Windows.Forms.CheckBox();
            this.ltcVersion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ignoreChecksum = new System.Windows.Forms.CheckBox();
            this.deleteTemp = new System.Windows.Forms.CheckBox();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show Directories";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open Installer Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Open Plays Directory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Open Plays-ltc Directory";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Open Roaming\\Plays Directory";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(224, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 137);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteTemp);
            this.groupBox3.Controls.Add(this.ignoreChecksum);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ltcVersion);
            this.groupBox3.Controls.Add(this.cleanInstall);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.playsSetupUrl);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 137);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Install Settings";
            // 
            // playsSetupUrl
            // 
            this.playsSetupUrl.Location = new System.Drawing.Point(6, 32);
            this.playsSetupUrl.Name = "playsSetupUrl";
            this.playsSetupUrl.Size = new System.Drawing.Size(390, 20);
            this.playsSetupUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PlaysSetup.exe Download URL";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(301, 108);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Apply Changes";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // cleanInstall
            // 
            this.cleanInstall.AutoSize = true;
            this.cleanInstall.Checked = true;
            this.cleanInstall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cleanInstall.Location = new System.Drawing.Point(9, 85);
            this.cleanInstall.Name = "cleanInstall";
            this.cleanInstall.Size = new System.Drawing.Size(83, 17);
            this.cleanInstall.TabIndex = 7;
            this.cleanInstall.Text = "Clean Install";
            this.cleanInstall.UseVisualStyleBackColor = true;
            // 
            // ltcVersion
            // 
            this.ltcVersion.FormattingEnabled = true;
            this.ltcVersion.Location = new System.Drawing.Point(76, 58);
            this.ltcVersion.Name = "ltcVersion";
            this.ltcVersion.Size = new System.Drawing.Size(58, 21);
            this.ltcVersion.TabIndex = 7;
            this.ltcVersion.Text = "0.54.7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "LTC version";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(178, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Uninstall Plays";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 77);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(178, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Uninstall Yarn";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // ignoreChecksum
            // 
            this.ignoreChecksum.AutoSize = true;
            this.ignoreChecksum.Location = new System.Drawing.Point(9, 108);
            this.ignoreChecksum.Name = "ignoreChecksum";
            this.ignoreChecksum.Size = new System.Drawing.Size(165, 17);
            this.ignoreChecksum.TabIndex = 9;
            this.ignoreChecksum.Text = "Ignore PlaysSetup Checksum";
            this.ignoreChecksum.UseVisualStyleBackColor = true;
            // 
            // deleteTemp
            // 
            this.deleteTemp.AutoSize = true;
            this.deleteTemp.Location = new System.Drawing.Point(98, 85);
            this.deleteTemp.Name = "deleteTemp";
            this.deleteTemp.Size = new System.Drawing.Size(165, 17);
            this.deleteTemp.TabIndex = 10;
            this.deleteTemp.Text = "Delete temp folder after install";
            this.deleteTemp.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 48);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(178, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Uninstall RePlays Installer";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 305);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Options";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.Load += new System.EventHandler(this.Options_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cleanInstall;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playsSetupUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ltcVersion;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox ignoreChecksum;
        private System.Windows.Forms.CheckBox deleteTemp;
        private System.Windows.Forms.Button button8;
    }
}