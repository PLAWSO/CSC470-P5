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
        int projectId;
        FakeFeatureRepository fakeFeatureRepository = new FakeFeatureRepository();
        FakeRequirementRepository fakeRequirementRepository = new FakeRequirementRepository();

        public FormModifyRequirement(int projectID, FakeRequirementRepository fakeRequirementRepo, FakeFeatureRepository fakeFeatureRepo)
        {
            InitializeComponent();
            projectId = projectID;
            fakeRequirementRepository = fakeRequirementRepo;
            fakeFeatureRepository = fakeFeatureRepo;
            List<Feature> features;

            features = fakeFeatureRepository.GetAll(projectID);
            foreach (Feature feature in features)
            {
                cbxFeatureSelect.Items.Add(feature.Title);
            }
        }

        private void btnCreateRequirement_Click(object sender, EventArgs e)
        {
            Feature feature = new Feature();
            Requirement requirement = new Requirement();
            cbxFeatureSelect.SelectedItem.Equals(feature);

            requirement.FeatureId = feature.Id;
            requirement.ProjectId = feature.ProjectId;
            requirement.Statement = tbxStatement.Text;

            string message = fakeRequirementRepository.Add(requirement);

            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
