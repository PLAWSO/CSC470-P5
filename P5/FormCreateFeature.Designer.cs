namespace Builder
{
    partial class FormCreateFeature
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
            this.txbxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCreateFeature = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbxTitle
            // 
            this.txbxTitle.Location = new System.Drawing.Point(97, 37);
            this.txbxTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbxTitle.Name = "txbxTitle";
            this.txbxTitle.Size = new System.Drawing.Size(513, 22);
            this.txbxTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(37, 41);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // btnCreateFeature
            // 
            this.btnCreateFeature.Location = new System.Drawing.Point(460, 105);
            this.btnCreateFeature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateFeature.Name = "btnCreateFeature";
            this.btnCreateFeature.Size = new System.Drawing.Size(152, 28);
            this.btnCreateFeature.TabIndex = 2;
            this.btnCreateFeature.Text = "Create Feature";
            this.btnCreateFeature.UseVisualStyleBackColor = true;
            this.btnCreateFeature.Click += new System.EventHandler(this.btnCreateFeature_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(267, 105);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormCreateFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(663, 151);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateFeature);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txbxTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCreateFeature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Feature";
            this.Load += new System.EventHandler(this.FormCreateFeature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreateFeature;
        private System.Windows.Forms.Button btnCancel;
    }
}