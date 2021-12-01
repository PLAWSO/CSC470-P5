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
    public partial class FormSelectFeauture : Form
    {
        FakeFeatureRepository FeatureRepo = new FakeFeatureRepository();
        public DataGridViewRow dataGridViewRow;
        public int projectID;
        public int featureID;

        public string Choice;

        public FormSelectFeauture(int projecID, string choice, FakeFeatureRepository fakeFeatureRepository)

        {
            projectID = projecID;
            Choice = choice;
            FeatureRepo = fakeFeatureRepository;
            InitializeComponent();

        }

        private void FormSelectFeauture_Load(object sender, EventArgs e)
        {
            List<Feature> feature = new List<Feature>();
            feature = FeatureRepo.GetAll(projectID);

            foreach (Feature f in feature)
            {
                dgFeature.Rows.Add(f.Id, f.Title);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Select_Click(object sender, EventArgs e)
        {

            featureID = Int32.Parse(dgFeature.SelectedRows[0].Cells[0].Value.ToString());

            if (Choice == "Modify")
            {
                dataGridViewRow = dgFeature.Rows[featureID];
                FormModifyFeature form = new FormModifyFeature(dataGridViewRow, projectID, FeatureRepo);
                form.ShowDialog();
                form.Dispose();
                this.Close();

            }
            else if (Choice == "Remove")
            {
                FakeRequirementRepository requirementRepo = new FakeRequirementRepository();
                Feature selectedFeature = FeatureRepo.GetFeatureById(projectID, featureID);

                DialogResult dialogResult;
                if (requirementRepo.CountByFeatureId(featureID) > 0)
                    dialogResult = MessageBox.Show("There are one or more requirements associated with this feature. These requirments will be destroyed if you remove this feature. Are you sure you want to remove: " + selectedFeature.Title + "?", "Confirmation", MessageBoxButtons.YesNo);
                else
                    dialogResult = MessageBox.Show("Are you sure you want to remove: " + selectedFeature.Title + "?", "Confirmation", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    FeatureRepo.Remove(selectedFeature);
                    dgFeature.Rows.Clear();
                    List<Feature> features = FeatureRepo.GetAll(projectID);
                    foreach (Feature f in features)
                        dgFeature.Rows.Add(f.Id, f.Title);
                }
            }
        }
    }
}
