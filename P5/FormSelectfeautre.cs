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
    public partial class FormSelectfeautre : Form
    {
        FakeFeatureRepository FeatureRepo = new FakeFeatureRepository();
        public int projectID;
        public int selectedFeature;
        public FormSelectfeautre(int projecID)
        {
            projectID = projecID;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void FormModifyfeautre_Load(object sender, EventArgs e)
        {
           
            List<Feature> feature = new List<Feature>();
            feature = FeatureRepo.GetAll(projectID);

            foreach (Feature f in feature)
            {
                dgFeature.Rows.Add(f.Id, f.Title);
            }

      
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void select_Click(object sender, EventArgs e)
        {
            selectedFeature = dgFeature.Rows.GetFirstRow(DataGridViewElementStates.Selected);

        }
    }
}
