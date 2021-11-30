using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P5;

namespace Builder
{
    public partial class FormCreateFeature : Form
    {
        private int projectId;
        FakeFeatureRepository fakeFeatureRepository = new FakeFeatureRepository();
        public FormCreateFeature(int projectID, FakeFeatureRepository fakeFeatureRepo)
        {
            InitializeComponent();
            projectId = projectID;
            fakeFeatureRepository = fakeFeatureRepo;
        }

        private void btnCreateFeature_Click(object sender, EventArgs e)
        {

            Feature feature = new Feature();
            feature.Title = txbxTitle.Text;
            feature.ProjectId = projectId;
            string message;
            message = fakeFeatureRepository.Add(feature);
          
            if(message != "")
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
