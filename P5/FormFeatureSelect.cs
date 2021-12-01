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
        public int selectedFeature;

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
            selectedFeature = dgFeature.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedFeature < 0)
            {
                DialogResult result = MessageBox.Show("An issue must be selected.", "Attention", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
            }
            else
            {
                if (Choice == "Modify")
                {
                    dataGridViewRow = dgFeature.Rows[selectedFeature];
                    FormModifyFeature form = new FormModifyFeature(dataGridViewRow, projectID, FeatureRepo);
                    form.ShowDialog();
                    form.Dispose();
                    this.Close();
                }
            }
        }
    }
}
