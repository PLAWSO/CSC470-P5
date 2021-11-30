
namespace Builder
{
    partial class FormFeatureSelect
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
            this.Tittle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFeature)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFeature
            // 
            this.dgFeature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFeature.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tittle});
            this.dgFeature.Location = new System.Drawing.Point(66, 39);
            this.dgFeature.Name = "dgFeature";
            this.dgFeature.ReadOnly = true;
            this.dgFeature.RowHeadersWidth = 51;
            this.dgFeature.RowTemplate.Height = 24;
            this.dgFeature.Size = new System.Drawing.Size(604, 303);
            this.dgFeature.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Tittle
            // 
            this.Tittle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tittle.HeaderText = "Title";
            this.Tittle.MinimumWidth = 6;
            this.Tittle.Name = "Tittle";
            this.Tittle.ReadOnly = true;
            // 
            // FormFeatureSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgFeature);
            this.Name = "FormFeatureSelect";
            this.Text = "Select Feature";
            this.Load += new System.EventHandler(this.FormFeatureSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFeature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFeature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tittle;
    }
}