namespace Builder
{
    partial class FormIssueRecorder
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.DicoveryDateLable = new System.Windows.Forms.Label();
            this.DiscoveryDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Discover = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComponentTextbox = new System.Windows.Forms.TextBox();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.StatusList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(78, 40);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(28, 21);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "Id:";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Location = new System.Drawing.Point(119, 43);
            this.IdTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.ReadOnly = true;
            this.IdTextbox.Size = new System.Drawing.Size(76, 20);
            this.IdTextbox.TabIndex = 2;
            this.IdTextbox.TextChanged += new System.EventHandler(this.IdTextbox_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(72, 61);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(39, 17);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title:";
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Location = new System.Drawing.Point(119, 66);
            this.TitleTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.Size = new System.Drawing.Size(319, 20);
            this.TitleTextbox.TabIndex = 4;
            // 
            // DicoveryDateLable
            // 
            this.DicoveryDateLable.AutoSize = true;
            this.DicoveryDateLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DicoveryDateLable.Location = new System.Drawing.Point(9, 87);
            this.DicoveryDateLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DicoveryDateLable.Name = "DicoveryDateLable";
            this.DicoveryDateLable.Size = new System.Drawing.Size(108, 17);
            this.DicoveryDateLable.TabIndex = 5;
            this.DicoveryDateLable.Text = "Discovery Date:";
            // 
            // DiscoveryDate
            // 
            this.DiscoveryDate.Location = new System.Drawing.Point(119, 89);
            this.DiscoveryDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DiscoveryDate.Name = "DiscoveryDate";
            this.DiscoveryDate.Size = new System.Drawing.Size(319, 20);
            this.DiscoveryDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Discoverer:";
            this.label1.UseWaitCursor = true;
            // 
            // Discover
            // 
            this.Discover.FormattingEnabled = true;
            this.Discover.Location = new System.Drawing.Point(119, 111);
            this.Discover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Discover.Name = "Discover";
            this.Discover.Size = new System.Drawing.Size(92, 21);
            this.Discover.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Component:";
            // 
            // ComponentTextbox
            // 
            this.ComponentTextbox.Location = new System.Drawing.Point(119, 136);
            this.ComponentTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComponentTextbox.Name = "ComponentTextbox";
            this.ComponentTextbox.Size = new System.Drawing.Size(319, 20);
            this.ComponentTextbox.TabIndex = 10;
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslabel.Location = new System.Drawing.Point(60, 163);
            this.Statuslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(52, 17);
            this.Statuslabel.TabIndex = 11;
            this.Statuslabel.Text = "Status:";
            // 
            // StatusList
            // 
            this.StatusList.FormattingEnabled = true;
            this.StatusList.Location = new System.Drawing.Point(119, 163);
            this.StatusList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusList.Name = "StatusList";
            this.StatusList.Size = new System.Drawing.Size(92, 21);
            this.StatusList.TabIndex = 12;
            this.StatusList.SelectedIndexChanged += new System.EventHandler(this.Status_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Initial Description:";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(42, 206);
            this.Description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(396, 232);
            this.Description.TabIndex = 14;
            this.Description.TextChanged += new System.EventHandler(this.Description_TextChanged);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(194, 472);
            this.cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(94, 31);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(323, 472);
            this.Create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(94, 31);
            this.Create.TabIndex = 16;
            this.Create.Text = "Create Issue";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // FormIssueRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 528);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StatusList);
            this.Controls.Add(this.Statuslabel);
            this.Controls.Add(this.ComponentTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Discover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiscoveryDate);
            this.Controls.Add(this.DicoveryDateLable);
            this.Controls.Add(this.TitleTextbox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.IdLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormIssueRecorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextbox;
        private System.Windows.Forms.Label DicoveryDateLable;
        private System.Windows.Forms.DateTimePicker DiscoveryDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Discover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ComponentTextbox;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.ComboBox StatusList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Create;
    }
}