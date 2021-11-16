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
    public partial class FormIssueDashboard : Form
    {

        public FormIssueDashboard()
        {
            InitializeComponent();

            FormMain formMain = new FormMain();
            FakePreferenceRepository fakePrefRepo = new FakePreferenceRepository();
            AppUser appUser = new AppUser();
            
            FakeIssueRepository issueRepo = new FakeIssueRepository();
            int issuesNum = Int32.Parse(fakePrefRepo.GetPreference("dave", "Project_Id"));
            lblNumIssues.Text = issueRepo.GetTotalNumberOfIssues(issuesNum).ToString();

            List<string> issueByMonth = issueRepo.GetIssuesByMonth(issuesNum);
            foreach (string issue in issueByMonth)
            {
                lbxIssuesByMonth.Items.Add(issue);
            }

            List<string> issueByUser = issueRepo.GetIssuesByDiscoverer(issuesNum);
            foreach (string user in issueByUser)
            {
                lbxIssuesByDiscoverer.Items.Add(user);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

    }
}
