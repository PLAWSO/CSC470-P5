using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class FormModifyFeature : Form
    {
        public string textfill;
        public int id;
        public int prjectId;
        public FormModifyFeature(DataGridViewRow dataGridViewRow, int projectId)
        {
            projectId = prjectId;
            textfill = dataGridViewRow.Cells[1].Value.ToString();
            id = Convert.ToInt32(dataGridViewRow.Cells[0].Value);
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModifyFeature_Load(object sender, EventArgs e)
        {
            TextTitle.Text = textfill;
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            FakeFeatureRepository featurerepo = new FakeFeatureRepository();
            Feature feat = new Feature();
            if (TextTitle.Text == "")
                MessageBox.Show("A title cannot be empty", "Attention", MessageBoxButtons.OKCancel);
            else
            {
                string message;
                feat.Title = TextTitle.Text.Trim();
                feat.Id = id;
                feat.ProjectId = prjectId;
                message = featurerepo.Modify(feat);
                if (message == "check")
                    this.Close();
                else
                    MessageBox.Show(message);
            }
        }
    }
}
