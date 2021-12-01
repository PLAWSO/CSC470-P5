
namespace Builder
{
    partial class FormModifyRequirement
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
            this.cbxFeatureSelect = new System.Windows.Forms.ComboBox();
            this.lblStatement = new System.Windows.Forms.Label();
            this.tbxStatement = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateRequirement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFeature
            // 
            this.lblFeature.AutoSize = true;
            this.lblFeature.Location = new System.Drawing.Point(39, 38);
            this.lblFeature.Name = "lblFeature";
            this.lblFeature.Size = new System.Drawing.Size(46, 13);
            this.lblFeature.TabIndex = 3;
            this.lblFeature.Text = "Feature:";
            // 
            // cbxFeatureSelect
            // 
            this.cbxFeatureSelect.FormattingEnabled = true;
            this.cbxFeatureSelect.Location = new System.Drawing.Point(91, 36);
            this.cbxFeatureSelect.Name = "cbxFeatureSelect";
            this.cbxFeatureSelect.Size = new System.Drawing.Size(503, 21);
            this.cbxFeatureSelect.TabIndex = 4;
            this.cbxFeatureSelect.Text = "<Make Selection>";
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Location = new System.Drawing.Point(27, 79);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(58, 13);
            this.lblStatement.TabIndex = 5;
            this.lblStatement.Text = "Statement:";
            // 
            // tbxStatement
            // 
            this.tbxStatement.Location = new System.Drawing.Point(91, 79);
            this.tbxStatement.Multiline = true;
            this.tbxStatement.Name = "tbxStatement";

            this.tbxStatement.Size = new System.Drawing.Size(503, 261);
            this.tbxStatement.TabIndex = 6;

            this.tbxStatement.TextChanged += new System.EventHandler(this.tbxStatement_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(247, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreateRequirement
            // 
            this.btnCreateRequirement.Location = new System.Drawing.Point(429, 371);
            this.btnCreateRequirement.Name = "btnCreateRequirement";
            this.btnCreateRequirement.Size = new System.Drawing.Size(151, 23);
            this.btnCreateRequirement.TabIndex = 8;
            this.btnCreateRequirement.Text = "Modify Requirement";
            this.btnCreateRequirement.UseVisualStyleBackColor = true;
            this.btnCreateRequirement.Click += new System.EventHandler(this.btnCreateRequirement_Click_1);
            // 
            // FormModifyRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 413);
            this.Controls.Add(this.btnCreateRequirement);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxStatement);
            this.Controls.Add(this.lblStatement);
            this.Controls.Add(this.cbxFeatureSelect);
            this.Controls.Add(this.lblFeature);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormModifyRequirement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SelectRequirement";
            this.Load += new System.EventHandler(this.FormModifyRequirement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.ComboBox cbxFeatureSelect;
        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.TextBox tbxStatement;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateRequirement;
    }
}