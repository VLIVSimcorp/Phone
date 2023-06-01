
namespace WindowsFormsApplication
{
    partial class MessageFormatting
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FormattingComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SendMessage = new System.Windows.Forms.Button();
            this.ChargingButton = new System.Windows.Forms.Button();
            this.CallsButton = new System.Windows.Forms.Button();
            this.GenerateCallsButton = new System.Windows.Forms.Button();
            this.MessageBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchByUserComboBox = new System.Windows.Forms.ComboBox();
            this.SearchByText = new System.Windows.Forms.TextBox();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BatteryVolumeProgressBar = new System.Windows.Forms.ProgressBar();
            this.MessagesListView = new System.Windows.Forms.ListView();
            this.UpdateBatteryVolumeTimer = new System.Windows.Forms.Timer(this.components);
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MessagesListView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 772);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.FormattingComboBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.MessageBox1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.BatteryVolumeProgressBar, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 225);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // FormattingComboBox
            // 
            this.FormattingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormattingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormattingComboBox.FormattingEnabled = true;
            this.FormattingComboBox.Items.AddRange(new object[] {
            "None",
            "Start with date",
            "End with date",
            "Uppercase",
            "Lowercase"});
            this.FormattingComboBox.Location = new System.Drawing.Point(3, 115);
            this.FormattingComboBox.Name = "FormattingComboBox";
            this.FormattingComboBox.Size = new System.Drawing.Size(391, 21);
            this.FormattingComboBox.TabIndex = 0;
            this.FormattingComboBox.SelectedIndexChanged += new System.EventHandler(this.FormattingComboBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.SendMessage, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.ChargingButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.CallsButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.GenerateCallsButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 171);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(391, 51);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // SendMessage
            // 
            this.SendMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendMessage.Location = new System.Drawing.Point(198, 28);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(190, 20);
            this.SendMessage.TabIndex = 2;
            this.SendMessage.Text = "Generate messages";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // ChargingButton
            // 
            this.ChargingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChargingButton.Location = new System.Drawing.Point(3, 28);
            this.ChargingButton.Name = "ChargingButton";
            this.ChargingButton.Size = new System.Drawing.Size(189, 20);
            this.ChargingButton.TabIndex = 3;
            this.ChargingButton.Text = "Start\\Stop charging";
            this.ChargingButton.UseVisualStyleBackColor = true;
            this.ChargingButton.Click += new System.EventHandler(this.ChargingButton_Click);
            // 
            // CallsButton
            // 
            this.CallsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CallsButton.Location = new System.Drawing.Point(198, 3);
            this.CallsButton.Name = "CallsButton";
            this.CallsButton.Size = new System.Drawing.Size(190, 19);
            this.CallsButton.TabIndex = 4;
            this.CallsButton.Text = "View calls";
            this.CallsButton.UseVisualStyleBackColor = true;
            this.CallsButton.Click += new System.EventHandler(this.CallsButton_Click);
            // 
            // GenerateCallsButton
            // 
            this.GenerateCallsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateCallsButton.Location = new System.Drawing.Point(3, 3);
            this.GenerateCallsButton.Name = "GenerateCallsButton";
            this.GenerateCallsButton.Size = new System.Drawing.Size(189, 19);
            this.GenerateCallsButton.TabIndex = 5;
            this.GenerateCallsButton.Text = "Generate calls";
            this.GenerateCallsButton.UseVisualStyleBackColor = true;
            this.GenerateCallsButton.Click += new System.EventHandler(this.GenerateCallsButton_Click);
            // 
            // MessageBox1
            // 
            this.MessageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBox1.Location = new System.Drawing.Point(400, 171);
            this.MessageBox1.Multiline = true;
            this.MessageBox1.Name = "MessageBox1";
            this.MessageBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageBox1.Size = new System.Drawing.Size(391, 51);
            this.MessageBox1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.SearchByUserComboBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.SearchByText, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.FromDateTimePicker, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.ToDateTimePicker, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(400, 115);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(391, 50);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // SearchByUserComboBox
            // 
            this.SearchByUserComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchByUserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchByUserComboBox.FormattingEnabled = true;
            this.SearchByUserComboBox.Location = new System.Drawing.Point(3, 3);
            this.SearchByUserComboBox.Name = "SearchByUserComboBox";
            this.SearchByUserComboBox.Size = new System.Drawing.Size(189, 21);
            this.SearchByUserComboBox.TabIndex = 0;
            this.SearchByUserComboBox.Leave += new System.EventHandler(this.SearchByUserComboBox_Leave);
            // 
            // SearchByText
            // 
            this.SearchByText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchByText.Location = new System.Drawing.Point(198, 3);
            this.SearchByText.Name = "SearchByText";
            this.SearchByText.Size = new System.Drawing.Size(190, 20);
            this.SearchByText.TabIndex = 1;
            this.SearchByText.Leave += new System.EventHandler(this.SearchByText_Leave);
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromDateTimePicker.Location = new System.Drawing.Point(3, 28);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(189, 20);
            this.FromDateTimePicker.TabIndex = 2;
            this.FromDateTimePicker.Leave += new System.EventHandler(this.FromDateTimePicker_Leave);
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToDateTimePicker.Location = new System.Drawing.Point(198, 28);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.ToDateTimePicker.TabIndex = 3;
            this.ToDateTimePicker.Leave += new System.EventHandler(this.ToDateTimePicker_Leave);
            // 
            // BatteryVolumeProgressBar
            // 
            this.BatteryVolumeProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BatteryVolumeProgressBar.Location = new System.Drawing.Point(3, 59);
            this.BatteryVolumeProgressBar.Name = "BatteryVolumeProgressBar";
            this.BatteryVolumeProgressBar.Size = new System.Drawing.Size(391, 23);
            this.BatteryVolumeProgressBar.Step = 1;
            this.BatteryVolumeProgressBar.TabIndex = 4;
            this.BatteryVolumeProgressBar.Value = 100;
            // 
            // MessagesListView
            // 
            this.MessagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User,
            this.Message,
            this.Time});
            this.MessagesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesListView.HideSelection = false;
            this.MessagesListView.Location = new System.Drawing.Point(3, 234);
            this.MessagesListView.Name = "MessagesListView";
            this.MessagesListView.Size = new System.Drawing.Size(794, 535);
            this.MessagesListView.TabIndex = 2;
            this.MessagesListView.UseCompatibleStateImageBehavior = false;
            this.MessagesListView.View = System.Windows.Forms.View.Tile;
            // 
            // UpdateBatteryVolumeTimer
            // 
            this.UpdateBatteryVolumeTimer.Interval = 1000;
            this.UpdateBatteryVolumeTimer.Tick += new System.EventHandler(this.UpdateBatteryVolumeTimer_Tick);
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 170;
            // 
            // Message
            // 
            this.Message.Text = "Message";
            this.Message.Width = 150;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 146;
            // 
            // MessageFormatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 772);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MessageFormatting";
            this.Text = "MessageFormatting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessageFormatting_FormClosing);
            this.Load += new System.EventHandler(this.MessageFormatting_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox FormattingComboBox;
        private System.Windows.Forms.ListView MessagesListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.TextBox MessageBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox SearchByUserComboBox;
        private System.Windows.Forms.TextBox SearchByText;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.ProgressBar BatteryVolumeProgressBar;
        private System.Windows.Forms.Timer UpdateBatteryVolumeTimer;
        private System.Windows.Forms.Button ChargingButton;
        private System.Windows.Forms.Button CallsButton;
        private System.Windows.Forms.Button GenerateCallsButton;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.ColumnHeader Time;
    }
}