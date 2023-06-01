
namespace WindowsFormsApplication
{
    partial class CallForm
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
            this.CallsTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // CallsTreeView
            // 
            this.CallsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CallsTreeView.Location = new System.Drawing.Point(0, 0);
            this.CallsTreeView.Name = "CallsTreeView";
            this.CallsTreeView.Size = new System.Drawing.Size(324, 450);
            this.CallsTreeView.TabIndex = 0;
            // 
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 450);
            this.Controls.Add(this.CallsTreeView);
            this.Name = "CallForm";
            this.Text = "CallForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView CallsTreeView;
    }
}