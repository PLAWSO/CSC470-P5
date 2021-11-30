namespace Builder
{
    partial class FormCreateRequirement
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
            this.cbxFeatureSelect = new System.Windows.Forms.ComboBox();
            this.tbxStatement = new System.Windows.Forms.TextBox();
            this.lblFeature = new System.Windows.Forms.Label();
            this.lblStatement = new System.Windows.Forms.Label();
            this.btnCreateRequirement = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxFeatureSelect
            // 
            this.cbxFeatureSelect.FormattingEnabled = true;
            this.cbxFeatureSelect.Location = new System.Drawing.Point(82, 36);
            this.cbxFeatureSelect.Name = "cbxFeatureSelect";
            this.cbxFeatureSelect.Size = new System.Drawing.Size(503, 21);
            this.cbxFeatureSelect.TabIndex = 0;
            this.cbxFeatureSelect.Text = "<Make Selection>";
            // 
            // tbxStatement
            // 
            this.tbxStatement.Location = new System.Drawing.Point(82, 75);
            this.tbxStatement.Multiline = true;
            this.tbxStatement.Name = "tbxStatement";
            this.tbxStatement.Size = new System.Drawing.Size(503, 261);
            this.tbxStatement.TabIndex = 1;
            // 
            // lblFeature
            // 
            this.lblFeature.AutoSize = true;
            this.lblFeature.Location = new System.Drawing.Point(29, 39);
            this.lblFeature.Name = "lblFeature";
            this.lblFeature.Size = new System.Drawing.Size(46, 13);
            this.lblFeature.TabIndex = 2;
            this.lblFeature.Text = "Feature:";
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Location = new System.Drawing.Point(17, 78);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(58, 13);
            this.lblStatement.TabIndex = 3;
            this.lblStatement.Text = "Statement:";
            // 
            // btnCreateRequirement
            // 
            this.btnCreateRequirement.Location = new System.Drawing.Point(434, 373);
            this.btnCreateRequirement.Name = "btnCreateRequirement";
            this.btnCreateRequirement.Size = new System.Drawing.Size(151, 23);
            this.btnCreateRequirement.TabIndex = 4;
            this.btnCreateRequirement.Text = "Create Requirement";
            this.btnCreateRequirement.UseVisualStyleBackColor = true;
            this.btnCreateRequirement.Click += new System.EventHandler(this.btnCreateRequirement_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(242, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormCreateRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(649, 418);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateRequirement);
            this.Controls.Add(this.lblStatement);
            this.Controls.Add(this.lblFeature);
            this.Controls.Add(this.tbxStatement);
            this.Controls.Add(this.cbxFeatureSelect);
            this.Name = "FormCreateRequirement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Requirement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFeatureSelect;
        private System.Windows.Forms.TextBox tbxStatement;
        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.Button btnCreateRequirement;
        private System.Windows.Forms.Button btnCancel;
    }
}