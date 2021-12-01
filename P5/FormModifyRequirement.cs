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
    public partial class FormModifyRequirement : Form
    {
        FakeFeatureRepository featureRepo = new FakeFeatureRepository();
        Requirement req;
        int projectId;

        public FormModifyRequirement(Requirement req, int projectId)
        {
            this.req = req;
            this.projectId = projectId;

            List<Feature> featureList = featureRepo.GetAll(this.projectId);
            foreach (Feature f in featureList)
                cbxFeature.Items.Add(f.Title);

            tbxStatement.Text = req.Statement;

        }

        private void FormModifyRequirement_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateRequirement_Click(object sender, EventArgs e)
        {
            if (tbxStatement.Text == "")
                MessageBox.Show("Statement must have a value", "Attention");
            else
            {
                FakeFeatureRepository repo = new FakeFeatureRepository();
                Feature feature = repo.GetFeatureByTitle(cbxFeature.SelectedItem.ToString());
                req.Statement = tbxStatement.Text;
                req.FeatureId = feature.Id;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateRequirement_Click_1(object sender, EventArgs e)
        {

        }


        private void tbxStatement_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
