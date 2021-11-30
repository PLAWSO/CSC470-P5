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
        public FormCreateFeature()
        {
            InitializeComponent();
        }

        private void btnCreateFeature_Click(object sender, EventArgs e)
        {
            FakeFeatureRepository fakeFeatureRepository = new FakeFeatureRepository();
            Feature feature = new Feature();
            feature.Title = txbxTitle.Text;
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
