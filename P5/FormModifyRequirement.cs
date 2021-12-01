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

        public FormModifyRequirement(Requirement req, int projectId)
        {
            this.req = req;

            List<Feature> featureList = featureRepo.GetAll(projectId);
            foreach (Feature f in featureList)
                cbxFeatureSelect.Items.Add(f.Title);
        }

        private void btnCreateRequirement_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormModifyRequirement_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateRequirement_Click_1(object sender, EventArgs e)
        {

        }


        private void tbxStatement_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
