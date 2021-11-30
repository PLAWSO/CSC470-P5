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
    public partial class FormIssueSelect : Form
    {

        FakeIssueRepository FakeIssueRepository = new FakeIssueRepository();
        FakeIssueStatusRepository FakeIssueStatusRepository = new FakeIssueStatusRepository();
        public int projectID;
        public string _eventAction;
        public DataGridViewRow dataGridViewRow;
        public int selectedIssueId;
        public Issue selectedIssue;
        public FormIssueSelect(int projectId, string _event)
        {
            projectID = projectId;
            _eventAction = _event;
            InitializeComponent();
        }

        private void FormIssueSelect_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            List<Issue> issues = new List<Issue>();
            issues = FakeIssueRepository.GetAll(projectID);

            foreach (Issue issue in issues)
            {
                string status;

                status = FakeIssueStatusRepository.GetValueById(issue.IssueStatusId);
                dgdSelectIssue.Rows.Add(
                    issue.Id,
                    issue.Title,
                    issue.DiscoveryDate,
                    issue.Discoverer,
                    issue.InitialDescription,
                    issue.Component,
                    status
                    );
            }
        }

        private void btnSelectIssue_Click(object sender, EventArgs e)
        {
            selectedIssueId = dgdSelectIssue.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedIssueId < 0)
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
                dataGridViewRow = dgdSelectIssue.Rows[selectedIssueId];
                if (_eventAction == "Modify")
                {
                    FormIssueModify form = new FormIssueModify(dataGridViewRow);
                    form.ShowDialog();
                    form.Dispose();
                    this.Close();
                }
                else if (_eventAction == "Remove")
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove: " + dataGridViewRow.Cells[1].Value, "Confirmation", MessageBoxButtons.YesNo);
                    selectedIssue = FakeIssueRepository.GetIssueById(selectedIssueId);
                    if (dialogResult == DialogResult.Yes)
                    {
                        FakeIssueRepository.Remove(selectedIssue);
                        this.Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Remove Canceled.", "Attention");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void dgdSelectIssue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
