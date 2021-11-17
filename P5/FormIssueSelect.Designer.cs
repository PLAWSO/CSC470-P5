
namespace Builder
{
    partial class FormIssueSelect
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
            this.btnSelectIssue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgdSelectIssue = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscoveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discoverer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgdSelectIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectIssue
            // 
            this.btnSelectIssue.Location = new System.Drawing.Point(929, 439);
            this.btnSelectIssue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectIssue.Name = "btnSelectIssue";
            this.btnSelectIssue.Size = new System.Drawing.Size(147, 28);
            this.btnSelectIssue.TabIndex = 1;
            this.btnSelectIssue.Text = "Select Issue";
            this.btnSelectIssue.UseVisualStyleBackColor = true;
            this.btnSelectIssue.Click += new System.EventHandler(this.btnSelectIssue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(747, 439);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgdSelectIssue
            // 
            this.dgdSelectIssue.AllowUserToAddRows = false;
            this.dgdSelectIssue.AllowUserToDeleteRows = false;
            this.dgdSelectIssue.AllowUserToResizeColumns = false;
            this.dgdSelectIssue.AllowUserToResizeRows = false;
            this.dgdSelectIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdSelectIssue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.DiscoveryDate,
            this.Discoverer,
            this.InitialDescription,
            this.Component,
            this.Status});
            this.dgdSelectIssue.Location = new System.Drawing.Point(31, 15);
            this.dgdSelectIssue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgdSelectIssue.MultiSelect = false;
            this.dgdSelectIssue.Name = "dgdSelectIssue";
            this.dgdSelectIssue.RowHeadersWidth = 51;
            this.dgdSelectIssue.Size = new System.Drawing.Size(1055, 405);
            this.dgdSelectIssue.TabIndex = 3;
            this.dgdSelectIssue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdSelectIssue_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 175;
            // 
            // DiscoveryDate
            // 
            this.DiscoveryDate.HeaderText = "DiscoveryDate";
            this.DiscoveryDate.MinimumWidth = 6;
            this.DiscoveryDate.Name = "DiscoveryDate";
            this.DiscoveryDate.ReadOnly = true;
            this.DiscoveryDate.Width = 140;
            // 
            // Discoverer
            // 
            this.Discoverer.HeaderText = "Discoverer";
            this.Discoverer.MinimumWidth = 6;
            this.Discoverer.Name = "Discoverer";
            this.Discoverer.ReadOnly = true;
            this.Discoverer.Width = 125;
            // 
            // InitialDescription
            // 
            this.InitialDescription.HeaderText = "InitialDescription";
            this.InitialDescription.MinimumWidth = 6;
            this.InitialDescription.Name = "InitialDescription";
            this.InitialDescription.ReadOnly = true;
            this.InitialDescription.Width = 125;
            // 
            // Component
            // 
            this.Component.HeaderText = "Component";
            this.Component.MinimumWidth = 6;
            this.Component.Name = "Component";
            this.Component.ReadOnly = true;
            this.Component.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // FormIssueSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1117, 495);
            this.Controls.Add(this.dgdSelectIssue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelectIssue);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormIssueSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Issue";
            this.Load += new System.EventHandler(this.FormIssueSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdSelectIssue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectIssue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgdSelectIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscoveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discoverer;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitialDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}