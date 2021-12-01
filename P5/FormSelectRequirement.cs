using P5;
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
    public partial class FormSelectRequirement : Form
    {
        FakeRequirementRepository requirementRepo = new FakeRequirementRepository();
        FakeFeatureRepository featureRepo = new FakeFeatureRepository();
        string action;

        public FormSelectRequirement(int projectId, string action)
        {
            InitializeComponent();
        
            dgvRequirements.Enabled = false;
            this.action = action;

            List<Feature> featureList = featureRepo.GetAll(projectId);
            foreach (Feature f in featureList)
                cmbFeature.Items.Add(f.Title);
        }

        private void cmbFeature_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvRequirements.Enabled = true;
            dgvRequirements.Rows.Clear();
            Feature selectedFeature = featureRepo.GetFeatureByTitle(cmbFeature.SelectedItem.ToString());
            List<Requirement> requirementList = requirementRepo.GetAll();

            foreach (Requirement r in requirementList)
                if (r.FeatureId == selectedFeature.Id)
                    dgvRequirements.Rows.Add(r.Id, r.Statement);
        }

        private void dgvRequirements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectRequirement_Click(object sender, EventArgs e)
        {
            if (dgvRequirements.SelectedRows.Count > 0)
            {
                int reqID = (Int32.Parse(dgvRequirements.SelectedRows[0].Cells[0].Value.ToString()));
                Requirement req = requirementRepo.GetRequirementById(reqID);

                DialogResult dialogResult;
                if (this.action == "Remove")
                {
                    dialogResult = MessageBox.Show("Are you sure you want to remove: " + req.Statement + "?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        requirementRepo.Remove(req);

                        dgvRequirements.Rows.Clear();
                        Feature selectedFeature = featureRepo.GetFeatureByTitle(cmbFeature.SelectedItem.ToString());
                        List<Requirement> requirementList = requirementRepo.GetAll();

                        foreach (Requirement r in requirementList)
                            if (r.FeatureId == selectedFeature.Id)
                                dgvRequirements.Rows.Add(r.Id, r.Statement);
                    }
                }
                else if (this.action == "Modify")
                {
                    // Add stuff for modify

                }
            }
        }
    }
}
