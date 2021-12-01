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
    public partial class FormCreateRequirement : Form
    {
        int projectId;
        FakeFeatureRepository fakeFeatureRepository = new FakeFeatureRepository();
        FakeRequirementRepository fakeRequirementRepository = new FakeRequirementRepository();

        public FormCreateRequirement(int projectID, FakeRequirementRepository fakeRequirementRepo, FakeFeatureRepository fakeFeatureRepo)
        {
            InitializeComponent();
            this.projectId = projectID;
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
            Requirement requirement = new Requirement();
            FakeFeatureRepository featureRepo = new FakeFeatureRepository();
            Feature feature = featureRepo.GetFeatureByTitle(cbxFeatureSelect.SelectedItem.ToString());

            requirement.FeatureId = feature.Id;
            requirement.ProjectId = feature.ProjectId;
            requirement.Statement = tbxStatement.Text;

            fakeRequirementRepository.Add(requirement);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
