
namespace WindowsFormsApplication
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhoneSpeakerRadioButton = new System.Windows.Forms.RadioButton();
            this.UnofficialHeadsetRadioButton = new System.Windows.Forms.RadioButton();
            this.SamsungHeadsetRadioButton = new System.Windows.Forms.RadioButton();
            this.iPhoneHeadsetRadioButton = new System.Windows.Forms.RadioButton();
            this.ApplyPlaybackButton = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PhoneSpeakerRadioButton);
            this.groupBox1.Controls.Add(this.UnofficialHeadsetRadioButton);
            this.groupBox1.Controls.Add(this.SamsungHeadsetRadioButton);
            this.groupBox1.Controls.Add(this.iPhoneHeadsetRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select playback component";
            // 
            // PhoneSpeakerRadioButton
            // 
            this.PhoneSpeakerRadioButton.AutoSize = true;
            this.PhoneSpeakerRadioButton.Location = new System.Drawing.Point(6, 161);
            this.PhoneSpeakerRadioButton.Name = "PhoneSpeakerRadioButton";
            this.PhoneSpeakerRadioButton.Size = new System.Drawing.Size(99, 17);
            this.PhoneSpeakerRadioButton.TabIndex = 3;
            this.PhoneSpeakerRadioButton.TabStop = true;
            this.PhoneSpeakerRadioButton.Text = "Phone Speaker";
            this.PhoneSpeakerRadioButton.UseVisualStyleBackColor = true;
            // 
            // UnofficialHeadsetRadioButton
            // 
            this.UnofficialHeadsetRadioButton.AutoSize = true;
            this.UnofficialHeadsetRadioButton.Location = new System.Drawing.Point(6, 117);
            this.UnofficialHeadsetRadioButton.Name = "UnofficialHeadsetRadioButton";
            this.UnofficialHeadsetRadioButton.Size = new System.Drawing.Size(112, 17);
            this.UnofficialHeadsetRadioButton.TabIndex = 2;
            this.UnofficialHeadsetRadioButton.TabStop = true;
            this.UnofficialHeadsetRadioButton.Text = "Unofficial Headset";
            this.UnofficialHeadsetRadioButton.UseVisualStyleBackColor = true;
            // 
            // SamsungHeadsetRadioButton
            // 
            this.SamsungHeadsetRadioButton.AutoSize = true;
            this.SamsungHeadsetRadioButton.Location = new System.Drawing.Point(6, 77);
            this.SamsungHeadsetRadioButton.Name = "SamsungHeadsetRadioButton";
            this.SamsungHeadsetRadioButton.Size = new System.Drawing.Size(112, 17);
            this.SamsungHeadsetRadioButton.TabIndex = 1;
            this.SamsungHeadsetRadioButton.TabStop = true;
            this.SamsungHeadsetRadioButton.Text = "Samsung Headset";
            this.SamsungHeadsetRadioButton.UseVisualStyleBackColor = true;
            // 
            // iPhoneHeadsetRadioButton
            // 
            this.iPhoneHeadsetRadioButton.AutoSize = true;
            this.iPhoneHeadsetRadioButton.Location = new System.Drawing.Point(6, 36);
            this.iPhoneHeadsetRadioButton.Name = "iPhoneHeadsetRadioButton";
            this.iPhoneHeadsetRadioButton.Size = new System.Drawing.Size(101, 17);
            this.iPhoneHeadsetRadioButton.TabIndex = 0;
            this.iPhoneHeadsetRadioButton.TabStop = true;
            this.iPhoneHeadsetRadioButton.Text = "iPhone Headset";
            this.iPhoneHeadsetRadioButton.UseVisualStyleBackColor = true;
            // 
            // ApplyPlaybackButton
            // 
            this.ApplyPlaybackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyPlaybackButton.Location = new System.Drawing.Point(305, 197);
            this.ApplyPlaybackButton.Name = "ApplyPlaybackButton";
            this.ApplyPlaybackButton.Size = new System.Drawing.Size(113, 23);
            this.ApplyPlaybackButton.TabIndex = 2;
            this.ApplyPlaybackButton.Text = "Apply";
            this.ApplyPlaybackButton.UseVisualStyleBackColor = true;
            this.ApplyPlaybackButton.Click += new System.EventHandler(this.ApplyPlaybackButton_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.phoneTextBox.Location = new System.Drawing.Point(0, 226);
            this.phoneTextBox.Multiline = true;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(430, 351);
            this.phoneTextBox.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 577);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.ApplyPlaybackButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "WinForm Application";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PhoneSpeakerRadioButton;
        private System.Windows.Forms.RadioButton UnofficialHeadsetRadioButton;
        private System.Windows.Forms.RadioButton SamsungHeadsetRadioButton;
        private System.Windows.Forms.RadioButton iPhoneHeadsetRadioButton;
        private System.Windows.Forms.Button ApplyPlaybackButton;
        private System.Windows.Forms.TextBox phoneTextBox;
    }
}

