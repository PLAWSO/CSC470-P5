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
    public partial class FormIssueRecorder : Form
    {
        public int convert;
        public FormIssueRecorder()
        {
            InitializeComponent();
            FakeIssueRepository issueRepository = new FakeIssueRepository();
            FakePreferenceRepository fakePrefRepo = new FakePreferenceRepository();
            FakeIssueStatusRepository fakeIssueStatus = new FakeIssueStatusRepository();
            FakeAppUserRepository fakeUsers = new FakeAppUserRepository();
            FakeProjectRepository fakeProject = new FakeProjectRepository();
            AppUser appUser = new AppUser();
            List<AppUser> appUsers = fakeUsers.GetAll();
            foreach (AppUser Username in appUsers)
            {
                Discover.Items.Add(Username.FirstName);
            }
            Discover.SelectedIndex = 0;
            List<IssueStatus> status = fakeIssueStatus.GetAll();
            foreach(IssueStatus s in status)
            {
                StatusList.Items.Add(s.Value);
            }
            StatusList.SelectedIndex = 0;

            
            int issuesNum = Int32.Parse(fakePrefRepo.GetPreference("dave", "Project_Id"));
            convert = issueRepository.GetTotalNumberOfIssues(issuesNum) + 1;
            IdTextbox.Text = convert.ToString();


        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            Issue newIssue = new Issue();
            newIssue.Id = convert;
            newIssue.Title = TitleTextbox.Text.Trim();
            newIssue.DiscoveryDate = DiscoveryDate.Value;
            string discover = Discover.Text;
            newIssue.Discoverer = discover;
            newIssue.InitialDescription = Description.Text.Trim();
            newIssue.IssueStatusId = StatusList.SelectedIndex + 1;
            newIssue.Component = ComponentTextbox.Text.Trim();
            FakeIssueRepository issueRepository = new FakeIssueRepository();
            string result = issueRepository.Add(newIssue);
            this.Close();

        }
    }
}
