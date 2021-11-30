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
    public partial class FormIssueModify : Form
    {
        public int convert;
        public DataGridViewRow issueDataGridViewRow { get; set; }
        public FormIssueModify(DataGridViewRow dataGridViewRow)
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
            foreach (IssueStatus s in status)
            {
                StatusList.Items.Add(s.Value);
            }
            StatusList.SelectedIndex = 0;
            issueDataGridViewRow = dataGridViewRow;

            IdTextbox.Text = issueDataGridViewRow.Cells[0].Value.ToString();
            TitleTextbox.Text = issueDataGridViewRow.Cells[1].Value.ToString();
            DiscoveryDate.Value = (DateTime)issueDataGridViewRow.Cells[2].Value;
            Description.Text = issueDataGridViewRow.Cells[4].Value.ToString();
            ComponentTextbox.Text = issueDataGridViewRow.Cells[5].Value.ToString();
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

        private void btnModify_Click(object sender, EventArgs e)
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
            string result = issueRepository.Modify(newIssue);
            this.Close();

        }

        private void btnModify_Click_1(object sender, EventArgs e)
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
            string result = issueRepository.Modify(newIssue);
            if (result == "Success")
                this.Close();
            else
                MessageBox.Show(result);
        }
    }
}
