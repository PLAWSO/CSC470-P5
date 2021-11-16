
namespace Builder
{
    partial class FormIssueDashboard
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
            this.lblTotalNumberOfIssues = new System.Windows.Forms.Label();
            this.lblIssuesbyMonth = new System.Windows.Forms.Label();
            this.lblIssuesByDiscoverer = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbxIssuesByMonth = new System.Windows.Forms.ListBox();
            this.lbxIssuesByDiscoverer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumIssues = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalNumberOfIssues
            // 
            this.lblTotalNumberOfIssues.AutoSize = true;
            this.lblTotalNumberOfIssues.Location = new System.Drawing.Point(28, 76);
            this.lblTotalNumberOfIssues.Name = "lblTotalNumberOfIssues";
            this.lblTotalNumberOfIssues.Size = new System.Drawing.Size(119, 13);
            this.lblTotalNumberOfIssues.TabIndex = 0;
            this.lblTotalNumberOfIssues.Text = "Total Number of Issues:";

            // 
            // lblIssuesbyMonth
            // 
            this.lblIssuesbyMonth.AutoSize = true;
            this.lblIssuesbyMonth.Location = new System.Drawing.Point(28, 110);
            this.lblIssuesbyMonth.Name = "lblIssuesbyMonth";
            this.lblIssuesbyMonth.Size = new System.Drawing.Size(84, 13);
            this.lblIssuesbyMonth.TabIndex = 1;
            this.lblIssuesbyMonth.Text = "Issues by Month";

            // 
            // lblIssuesByDiscoverer
            // 
            this.lblIssuesByDiscoverer.AutoSize = true;
            this.lblIssuesByDiscoverer.Location = new System.Drawing.Point(28, 245);
            this.lblIssuesByDiscoverer.Name = "lblIssuesByDiscoverer";
            this.lblIssuesByDiscoverer.Size = new System.Drawing.Size(105, 13);
            this.lblIssuesByDiscoverer.TabIndex = 2;
            this.lblIssuesByDiscoverer.Text = "Issues by Discoverer";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(155, 384);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbxIssuesByMonth
            // 
            this.lbxIssuesByMonth.FormattingEnabled = true;
            this.lbxIssuesByMonth.Location = new System.Drawing.Point(31, 126);
            this.lbxIssuesByMonth.Name = "lbxIssuesByMonth";
            this.lbxIssuesByMonth.ScrollAlwaysVisible = true;
            this.lbxIssuesByMonth.Size = new System.Drawing.Size(209, 95);
            this.lbxIssuesByMonth.TabIndex = 4;
            // 
            // lbxIssuesByDiscoverer
            // 
            this.lbxIssuesByDiscoverer.FormattingEnabled = true;
            this.lbxIssuesByDiscoverer.Location = new System.Drawing.Point(31, 261);
            this.lbxIssuesByDiscoverer.Name = "lbxIssuesByDiscoverer";
            this.lbxIssuesByDiscoverer.ScrollAlwaysVisible = true;
            this.lbxIssuesByDiscoverer.Size = new System.Drawing.Size(209, 95);
            this.lbxIssuesByDiscoverer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // lblNumIssues
            // 
            this.lblNumIssues.AutoSize = true;
            this.lblNumIssues.Location = new System.Drawing.Point(165, 76);
            this.lblNumIssues.Name = "lblNumIssues";
            this.lblNumIssues.Size = new System.Drawing.Size(62, 13);
            this.lblNumIssues.TabIndex = 7;
            this.lblNumIssues.Text = "your mother";

            // 
            // FormIssueDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(282, 435);
            this.Controls.Add(this.lblNumIssues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxIssuesByDiscoverer);
            this.Controls.Add(this.lbxIssuesByMonth);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblIssuesByDiscoverer);
            this.Controls.Add(this.lblIssuesbyMonth);
            this.Controls.Add(this.lblTotalNumberOfIssues);
            this.Name = "FormIssueDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalNumberOfIssues;
        private System.Windows.Forms.Label lblIssuesbyMonth;
        private System.Windows.Forms.Label lblIssuesByDiscoverer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbxIssuesByMonth;
        private System.Windows.Forms.ListBox lbxIssuesByDiscoverer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumIssues;
    }
}