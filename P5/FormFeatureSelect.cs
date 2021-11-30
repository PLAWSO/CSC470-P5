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
    public partial class FormFeatureSelect : Form
    {
        FakeFeatureRepository FeatureRepo = new FakeFeatureRepository();
        public int projectID;
        public int selectedFeature;
        public FormFeatureSelect(int projecID)
        {
            projectID = projecID;
            InitializeComponent();
        }

        private void FormFeatureSelect_Load(object sender, EventArgs e)
        {
            List<Feature> feature = new List<Feature>();
            feature = FeatureRepo.GetAll(projectID);

            foreach (Feature f in feature)
            {
                dgFeature.Rows.Add(f.Id, f.Title);
            }
        }
    }
}
