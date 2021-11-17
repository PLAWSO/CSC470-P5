
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
            this.components = new System.ComponentModel.Container();
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
            this.fakeIssueRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakeIssueStatusRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgdSelectIssue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeIssueRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeIssueStatusRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectIssue
            // 
            this.btnSelectIssue.Location = new System.Drawing.Point(697, 357);
            this.btnSelectIssue.Name = "btnSelectIssue";
            this.btnSelectIssue.Size = new System.Drawing.Size(110, 23);
            this.btnSelectIssue.TabIndex = 1;
            this.btnSelectIssue.Text = "Select Issue";
            this.btnSelectIssue.UseVisualStyleBackColor = true;
            this.btnSelectIssue.Click += new System.EventHandler(this.btnSelectIssue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(560, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
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
            this.dgdSelectIssue.Location = new System.Drawing.Point(23, 12);
            this.dgdSelectIssue.Name = "dgdSelectIssue";
            this.dgdSelectIssue.Size = new System.Drawing.Size(791, 329);
            this.dgdSelectIssue.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 175;
            // 
            // DiscoveryDate
            // 
            this.DiscoveryDate.HeaderText = "DiscoveryDate";
            this.DiscoveryDate.Name = "DiscoveryDate";
            this.DiscoveryDate.ReadOnly = true;
            this.DiscoveryDate.Width = 140;
            // 
            // Discoverer
            // 
            this.Discoverer.HeaderText = "Discoverer";
            this.Discoverer.Name = "Discoverer";
            this.Discoverer.ReadOnly = true;
            // 
            // InitialDescription
            // 
            this.InitialDescription.HeaderText = "InitialDescription";
            this.InitialDescription.Name = "InitialDescription";
            this.InitialDescription.ReadOnly = true;
            // 
            // Component
            // 
            this.Component.HeaderText = "Component";
            this.Component.Name = "Component";
            this.Component.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // fakeIssueRepositoryBindingSource
            // 
            this.fakeIssueRepositoryBindingSource.DataSource = typeof(Builder.FakeIssueRepository);
            // 
            // fakeIssueStatusRepositoryBindingSource
            // 
            this.fakeIssueStatusRepositoryBindingSource.DataSource = typeof(Builder.FakeIssueStatusRepository);
            // 
            // FormIssueSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(838, 402);
            this.Controls.Add(this.dgdSelectIssue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelectIssue);
            this.Name = "FormIssueSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Issue";
            this.Load += new System.EventHandler(this.FormIssueSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdSelectIssue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeIssueRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeIssueStatusRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource fakeIssueStatusRepositoryBindingSource;
        private System.Windows.Forms.Button btnSelectIssue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource fakeIssueRepositoryBindingSource;
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