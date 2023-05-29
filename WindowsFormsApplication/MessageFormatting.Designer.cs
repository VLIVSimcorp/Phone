
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
            this.MessagesListView = new System.Windows.Forms.ListView();
            this.MessageTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SendMessage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            // MessagesListView
            // 
            this.MessagesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesListView.HideSelection = false;
            this.MessagesListView.Location = new System.Drawing.Point(3, 234);
            this.MessagesListView.Name = "MessagesListView";
            this.MessagesListView.Size = new System.Drawing.Size(794, 535);
            this.MessagesListView.TabIndex = 2;
            this.MessagesListView.UseCompatibleStateImageBehavior = false;
            this.MessagesListView.View = System.Windows.Forms.View.Tile;
            // 
            // MessageTimer
            // 
            this.MessageTimer.Interval = 1000;
            this.MessageTimer.Tick += new System.EventHandler(this.MessageTimer_Tick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.UserTextBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MessageTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.SendMessage, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 171);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(391, 51);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTextBox.Location = new System.Drawing.Point(3, 3);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(189, 20);
            this.UserTextBox.TabIndex = 0;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageTextBox.Location = new System.Drawing.Point(198, 3);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(190, 20);
            this.MessageTextBox.TabIndex = 1;
            // 
            // SendMessage
            // 
            this.SendMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendMessage.Location = new System.Drawing.Point(198, 28);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(190, 20);
            this.SendMessage.TabIndex = 2;
            this.SendMessage.Text = "SEND";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox FormattingComboBox;
        private System.Windows.Forms.Timer MessageTimer;
        private System.Windows.Forms.ListView MessagesListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendMessage;
    }
}