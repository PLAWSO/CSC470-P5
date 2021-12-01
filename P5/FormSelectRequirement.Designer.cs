
namespace Builder
{
    partial class FormSelectRequirement
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
            this.lblFeature = new System.Windows.Forms.Label();
            this.lblRequirements = new System.Windows.Forms.Label();
            this.dgvRequirements = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requirement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFeature = new System.Windows.Forms.ComboBox();
            this.btnSelectRequirement = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequirements)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFeature
            // 
            this.lblFeature.AutoSize = true;
            this.lblFeature.Location = new System.Drawing.Point(41, 20);
            this.lblFeature.Name = "lblFeature";
            this.lblFeature.Size = new System.Drawing.Size(46, 13);
            this.lblFeature.TabIndex = 0;
            this.lblFeature.Text = "Feature:";
            // 
            // lblRequirements
            // 
            this.lblRequirements.AutoSize = true;
            this.lblRequirements.Location = new System.Drawing.Point(12, 64);
            this.lblRequirements.Name = "lblRequirements";
            this.lblRequirements.Size = new System.Drawing.Size(75, 13);
            this.lblRequirements.TabIndex = 1;
            this.lblRequirements.Text = "Requirements:";
            // 
            // dgvRequirements
            // 
            this.dgvRequirements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequirements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Requirement});
            this.dgvRequirements.Location = new System.Drawing.Point(93, 64);
            this.dgvRequirements.MultiSelect = false;
            this.dgvRequirements.Name = "dgvRequirements";
            this.dgvRequirements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequirements.Size = new System.Drawing.Size(588, 322);
            this.dgvRequirements.TabIndex = 2;
            this.dgvRequirements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequirements_CellContentClick);
            // 
            // Id
            // 
            this.Id.FillWeight = 10F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Requirement
            // 
            this.Requirement.HeaderText = "Requirement";
            this.Requirement.Name = "Requirement";
            // 
            // cmbFeature
            // 
            this.cmbFeature.FormattingEnabled = true;
            this.cmbFeature.Location = new System.Drawing.Point(93, 20);
            this.cmbFeature.Name = "cmbFeature";
            this.cmbFeature.Size = new System.Drawing.Size(588, 21);
            this.cmbFeature.TabIndex = 3;
            this.cmbFeature.Text = "<Make Selection>";
            this.cmbFeature.SelectedIndexChanged += new System.EventHandler(this.cmbFeature_SelectedIndexChanged);
            // 
            // btnSelectRequirement
            // 
            this.btnSelectRequirement.Location = new System.Drawing.Point(556, 405);
            this.btnSelectRequirement.Name = "btnSelectRequirement";
            this.btnSelectRequirement.Size = new System.Drawing.Size(125, 23);
            this.btnSelectRequirement.TabIndex = 4;
            this.btnSelectRequirement.Text = "Select Requirement";
            this.btnSelectRequirement.UseVisualStyleBackColor = true;
            this.btnSelectRequirement.Click += new System.EventHandler(this.btnSelectRequirement_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(399, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormSelectRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelectRequirement);
            this.Controls.Add(this.cmbFeature);
            this.Controls.Add(this.dgvRequirements);
            this.Controls.Add(this.lblRequirements);
            this.Controls.Add(this.lblFeature);
            this.Name = "FormSelectRequirement";
            this.Text = "Select Requirement";
            this.Load += new System.EventHandler(this.FormSelectRequirement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequirements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.Label lblRequirements;
        private System.Windows.Forms.DataGridView dgvRequirements;
        private System.Windows.Forms.ComboBox cmbFeature;
        private System.Windows.Forms.Button btnSelectRequirement;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requirement;
    }
}