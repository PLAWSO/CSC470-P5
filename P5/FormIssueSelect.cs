﻿using System;
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
            if (_eventAction == "Modify")
            {

            }
        }
    }
}
