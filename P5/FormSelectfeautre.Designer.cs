
namespace Builder
{
    partial class FormSelectfeautre
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
            this.dgFeature = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakeFeatureRepositoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fakeFeatureRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.select = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFeature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeFeatureRepositoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeFeatureRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFeature
            // 
            this.dgFeature.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFeature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFeature.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Feature});
            this.dgFeature.Location = new System.Drawing.Point(56, 12);
            this.dgFeature.Name = "dgFeature";
            this.dgFeature.ReadOnly = true;
            this.dgFeature.RowHeadersWidth = 51;
            this.dgFeature.RowTemplate.Height = 24;
            this.dgFeature.Size = new System.Drawing.Size(667, 356);
            this.dgFeature.TabIndex = 0;
            this.dgFeature.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Feature
            // 
            this.Feature.FillWeight = 200F;
            this.Feature.HeaderText = "Feature";
            this.Feature.MinimumWidth = 6;
            this.Feature.Name = "Feature";
            this.Feature.ReadOnly = true;
            // 
            // fakeFeatureRepositoryBindingSource1
            // 
            this.fakeFeatureRepositoryBindingSource1.DataSource = typeof(Builder.FakeFeatureRepository);
            // 
            // fakeFeatureRepositoryBindingSource
            // 
            this.fakeFeatureRepositoryBindingSource.DataSource = typeof(Builder.FakeFeatureRepository);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(537, 386);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(145, 35);
            this.select.TabIndex = 1;
            this.select.Text = "Select Feature";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(339, 386);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(145, 35);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // FormModifyfeautre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.select);
            this.Controls.Add(this.dgFeature);
            this.Name = "FormModifyfeautre";
            this.Text = "Modify Feature";
            this.Load += new System.EventHandler(this.FormModifyfeautre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFeature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeFeatureRepositoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeFeatureRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource fakeFeatureRepositoryBindingSource;
        private System.Windows.Forms.DataGridView dgFeature;
        private System.Windows.Forms.BindingSource fakeFeatureRepositoryBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feature;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button cancel;
    }
}