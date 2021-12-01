
namespace Builder
{
    partial class FormSelectFeauture
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
            this.dgFeature = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFeature)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFeature
            // 
            this.dgFeature.AllowUserToAddRows = false;
            this.dgFeature.AllowUserToDeleteRows = false;
            this.dgFeature.AllowUserToOrderColumns = true;
            this.dgFeature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFeature.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title});
            this.dgFeature.Location = new System.Drawing.Point(28, 23);

            this.dgFeature.Margin = new System.Windows.Forms.Padding(2);
            this.dgFeature.MultiSelect = false;
            this.dgFeature.Name = "dgFeature";
            this.dgFeature.RowHeadersWidth = 51;
            this.dgFeature.RowTemplate.Height = 24;
            this.dgFeature.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFeature.ShowEditingIcon = false;

            this.dgFeature.Size = new System.Drawing.Size(486, 284);
            this.dgFeature.TabIndex = 0;
            this.dgFeature.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(206, 323)
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);

            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(108, 33);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(388, 323);

            this.Select.Margin = new System.Windows.Forms.Padding(2);

            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(108, 33);
            this.Select.TabIndex = 2;
            this.Select.Text = "Selcet";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // FormSelectFeauture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.dgFeature);

            this.Margin = new System.Windows.Forms.Padding(2);

            this.Name = "FormSelectFeauture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Feature";
            this.Load += new System.EventHandler(this.FormSelectFeauture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFeature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFeature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Select;
    }
}